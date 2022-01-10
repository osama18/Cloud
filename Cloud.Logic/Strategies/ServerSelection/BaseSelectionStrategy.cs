using Cloud.Logic.DomainModel;
using Cloud.Logic.Extensions;

namespace Cloud.Logic.Strategies
{
    public abstract class BaseSelectionStrategy : IServerSelectionStrateg
    {
        private readonly LoadBalancer _loadBalancer;

        public BaseSelectionStrategy(LoadBalancer loadBalancer)
        {
            _loadBalancer = loadBalancer;
        }

        public Server Next()
        {
            if (!_loadBalancer.HasServers())
                return null;

            int nextServerIndex = GetNextCustomeIndex(_loadBalancer.Count());

            return _loadBalancer.GetServerByIndex(nextServerIndex);
        }

        protected abstract int GetNextCustomeIndex(int numberOfServers);
    }
}