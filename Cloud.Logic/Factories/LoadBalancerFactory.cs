using Cloud.Common.DNS;
using Cloud.Logic.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Logic.Factories
{
    public class LoadBalancerFactory : ILoadBalancerFactory
    {
        private readonly IDNS _dns;
        public LoadBalancerFactory(IDNS dns)
        {
            _dns = dns;
        }
        public LoadBalancer Construct(string name, ServerSelectionStrategy serverSelectionStrategy, RateLimiter rateLimiter, int threadPoolCapacity, bool isPublicServer = true)
        {
            return new LoadBalancer(name,
                Guid.NewGuid(),
                _dns.ReserveIp(name),
                rateLimiter,
                serverSelectionStrategy,
                threadPoolCapacity);
        }
    }
}
