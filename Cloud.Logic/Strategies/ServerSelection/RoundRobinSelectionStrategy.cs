using Cloud.Logic.DomainModel;

namespace Cloud.Logic.Strategies
{
    public class RoundRobinSelectionStrategy : BaseSelectionStrategy
    {
        private int _lastSelectedServer;

        public RoundRobinSelectionStrategy(LoadBalancer loadBalancer) : base(loadBalancer)
        {
        }

        private void ValidateCount(int numberOfServers) => _lastSelectedServer = (_lastSelectedServer >= numberOfServers) ? _lastSelectedServer - numberOfServers : _lastSelectedServer;

        protected override int GetNextCustomeIndex(int numberOfServers)
        {
            _lastSelectedServer++;

            ValidateCount(numberOfServers);

            return _lastSelectedServer;
        }
    }
}