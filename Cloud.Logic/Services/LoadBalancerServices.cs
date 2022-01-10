using Cloud.Common.Configurations;
using Cloud.Logic.DomainModel;
using Cloud.Logic.Factories;
using System.Threading.Tasks;

namespace Cloud.Logic.Services
{
    public class LoadBalancerServices : BaseServerServices, ILoadBalancerServices
    {
        private readonly IServerLogger _serverLogger;
        private readonly IStaticConfigurationsReader _staticConfigurationsReader;

        public LoadBalancerServices(IServerLogger serverLogger, IStaticConfigurationsReader staticConfigurationsReader)
        {
            _serverLogger = serverLogger;
            _staticConfigurationsReader = staticConfigurationsReader;
        }

        public async Task Exclude(LoadBalancer loadBalancer, Server server)
        {
            using (var thread = ThreadPoolFactory.GetLoadBalancerThreadPool(loadBalancer))
            {
                thread.Exclude(server);
            }
        }

        public async Task Include(LoadBalancer loadBalancer, Server server)
        {
            using (var thread = ThreadPoolFactory.GetLoadBalancerThreadPool(loadBalancer))
            {
                thread.Include(server);
            }
        }

        public async Task Register(LoadBalancer loadBalancer, Server server)
        {
            using (var thread = ThreadPoolFactory.GetLoadBalancerThreadPool(loadBalancer))
            {
                thread.Register(server);
            }
        }
    }
}