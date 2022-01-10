using Cloud.Logic.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Logic.Factories
{
    public interface IRateLimiterFactory
    {
        RateLimiter ConstructDynamic(RateLimitingStrategy rateLimitingStrategy,RateLimitingTechnique rateLimitingTechnique, DynamicRateLimiterType dynamicRateLimiterType);
        RateLimiter ConstructStatic(RateLimitingStrategy rateLimitingStrategy, RateLimitingTechnique rateLimitingTechnique, int numberOfActiveRequests ,bool onlyForSameIP = false);
    }
}
