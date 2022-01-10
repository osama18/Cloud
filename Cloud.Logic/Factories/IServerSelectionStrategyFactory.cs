using Cloud.Logic.DomainModel;
using Cloud.Logic.Strategies;

namespace Cloud.Logic.Factories
{
    public interface IServerSelectionStrategyFactory
    {
        IServerSelectionStrateg Construct(LoadBalancer loadBalancer);
    }
}