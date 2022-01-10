using Cloud.Common.DataStrucures;
using Cloud.Logic.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cloud.Logic.DomainModel
{
    public class LoadBalancerThreadPool : ServerThreadPool
    {
        private readonly LoadBalancer _loadBalancer;
        private readonly IServerSelectionStrategyFactory _serverSelectionStrategyFactory;

        public LoadBalancerThreadPool(LoadBalancer loadBalancer, IServerSelectionStrategyFactory serverSelectionStrategyFactory) : base(loadBalancer)
        {
            _loadBalancer = loadBalancer;
            _serverSelectionStrategyFactory = serverSelectionStrategyFactory;
        }
        private Server GetInActiveServerByIp(string ip) => _loadBalancer.RegisteredInActiveServers.First(s => s.IP == ip);
        protected override void PerformDeepCheck()
        {
            //ExcludeInactive
            foreach (var server in _loadBalancer.RegisteredActiveServers)
            {
                var thread = ThreadPoolFactory.GetThreadPool(server);
                if (thread == null || !thread.Check())
                {
                    Exclude(server);
                }
                thread?.Dispose();
            }

            //Check on inactive
            foreach (var serverIP in _loadBalancer.InactiveServerTracker.GetAll())
            {
                var server = GetInActiveServerByIp(serverIP);
                var thread = ThreadPoolFactory.GetThreadPool(server);

                if (thread == null || !thread.Check())
                {
                    _loadBalancer.InactiveServerTracker.Activate(server.IP);
                }
                thread?.Dispose();
            }

            //Rwactivate Healthy Server
            foreach (var serverIP in _loadBalancer.InactiveServerTracker.PullActivatedItems())
            {
                Include(GetInActiveServerByIp(serverIP));
            }
        }

        public void Exclude(Server server)
        {
            Swap(_loadBalancer.RegisteredActiveServers, _loadBalancer.RegisteredInActiveServers, server);
            _loadBalancer.InactiveServerTracker.Deactivate(server.IP);
        }

        public void Include(Server server)
        {
            Swap(_loadBalancer.RegisteredInActiveServers, _loadBalancer.RegisteredActiveServers, server);
        }

        public void Register(Server server)
        {
            _loadBalancer.RegisteredActiveServers.Add(server);
        }

        private void Swap(IList<Server> source, IList<Server> destination, Server targetServer)
        {
            var serverInTheList = source.FirstOrDefault(s => s.Id == targetServer.Id);
            if (serverInTheList != null)
            {
                source.Remove(serverInTheList);
                destination.Add(serverInTheList);
            }
        }

        protected override Response PerformGet(Request request)
        {
            var strategy = _serverSelectionStrategyFactory.Construct(_loadBalancer);

            var  server = strategy.Next();

            using(var thread = ThreadPoolFactory.GetThreadPool(server))
            {
                return thread.Get(request);
            }
        }
    }
}
