using Cloud.Logic.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Logic.Factories
{
    public static class ThreadPoolFactory
    {
        public static ServerThreadPool GetThreadPool<T>(T server) where T : Server
        {
            if (server.GetThread())
            {
                if (server is Provider)
                {
                    return new ProviderThreadPool(server as Provider);
                }
                else if (server is LoadBalancer)
                {
                    return new LoadBalancerThreadPool(server as LoadBalancer, new ServerSelectionStrategyFactory());
                }
                return null;
            }
            return null;
        }

        public static LoadBalancerThreadPool GetLoadBalancerThreadPool(LoadBalancer server)
        {
            if (server.GetThread())
            {
                return new LoadBalancerThreadPool(server as LoadBalancer, new ServerSelectionStrategyFactory());
            }
            return null;
        }
    }
}
