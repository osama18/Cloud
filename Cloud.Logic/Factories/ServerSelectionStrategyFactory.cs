using Cloud.Logic.DomainModel;
using Cloud.Logic.Strategies;

namespace Cloud.Logic.Factories
{
    public class ServerSelectionStrategyFactory : IServerSelectionStrategyFactory
    {
        public IServerSelectionStrateg Construct(LoadBalancer loadBalancer)
        {
            switch (loadBalancer.ServerSelectionStrategy)
            {
                case ServerSelectionStrategy.Random:
                    return new RandomSelectionStrategy(loadBalancer);

                case ServerSelectionStrategy.RoundRobin:
                    return new RandomSelectionStrategy(loadBalancer);

                default:
                    throw new System.NotImplementedException($"The selecetd server startegy {loadBalancer.ServerSelectionStrategy} has no implementation");
            }
        }
    }
}