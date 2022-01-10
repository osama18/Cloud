using Cloud.Logic.DomainModel;

namespace Cloud.Logic.Factories
{
    public interface ILoadBalancerFactory
    {
        LoadBalancer Construct(string name, ServerSelectionStrategy serverSelectionStrategy, RateLimiter rateLimiter, int threadPoolCapacity, bool isPublicServer = true);
    }
}