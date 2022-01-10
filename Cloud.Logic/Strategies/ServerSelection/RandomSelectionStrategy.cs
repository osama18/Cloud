using Cloud.Common.RanomNumers;
using Cloud.Logic.DomainModel;

namespace Cloud.Logic.Strategies
{
    public class RandomSelectionStrategy : BaseSelectionStrategy
    {
        public RandomSelectionStrategy(LoadBalancer loadBalancer) : base(loadBalancer)
        {
        }

        protected override int GetNextCustomeIndex(int numberOfServers)
        {
            return RandomNumbersFactory.Construct(numberOfServers);
        }
    }
}