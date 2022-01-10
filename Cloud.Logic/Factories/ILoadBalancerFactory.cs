using Cloud.Logic.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Logic.Factories
{
    public interface ILoadBalancerFactory
    {
        LoadBalancer Construct(string name, ServerSelectionStrategy serverSelectionStrategy, RateLimiter rateLimiter, int threadPoolCapacity, bool isPublicServer = true);
    }
}
