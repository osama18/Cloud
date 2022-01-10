using Cloud.Logic.DomainModel;

namespace Cloud.Logic.Extensions
{
    public static class LoadBalancerExtensions
    {
        public static int Count(this LoadBalancer loadBalancer) => loadBalancer.RegisteredActiveServers?.Count ?? 0;

        public static bool HasServers(this LoadBalancer loadBalancer) => (loadBalancer.Count() > 0);

        public static Server GetServerByIndex(this LoadBalancer loadBalancer, int index)
        {
            if (!loadBalancer.HasServers())
                return null;

            return loadBalancer.RegisteredActiveServers[index];
        }
    }
}