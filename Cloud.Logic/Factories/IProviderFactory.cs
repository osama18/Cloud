using Cloud.Logic.DomainModel;

namespace Cloud.Logic.Factories
{
    public interface IProviderFactory
    {
        Provider Construct(string name, IApplication application, int threadPoolCapacity, bool isPublicServer = false, DomainModel.RateLimiter rateLimiter = null);
    }
}