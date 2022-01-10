using Cloud.Logic.DomainModel;

namespace Cloud.Logic.Factories
{
    public class RateLimiterFactory : IRateLimiterFactory
    {
        public RateLimiter ConstructDynamic(RateLimitingStrategy rateLimitingStrategy, RateLimitingTechnique rateLimitingTechnique, DynamicRateLimiterType dynamicRateLimiterType)
        {
            return new DynamicRateLimiter
            {
                DynamicRateLimiterType = dynamicRateLimiterType,
                RateLimitingStrategy = rateLimitingStrategy,
                RateLimitingTechnique = rateLimitingTechnique,
            };
        }

        public RateLimiter ConstructStatic(RateLimitingStrategy rateLimitingStrategy, RateLimitingTechnique rateLimitingTechnique, int numberOfActiveRequests, bool onlyForSameIP = false)
        {
            return new StaticRateLimiter
            {
                RateLimitingStrategy = rateLimitingStrategy,
                RateLimitingTechnique = rateLimitingTechnique,
                NumberOfActiveRequests = numberOfActiveRequests,
                OnlyForSameIP = onlyForSameIP
            };
        }
    }
}