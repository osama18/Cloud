using Cloud.Common.DNS;
using Cloud.Logic.DeploymentTools;
using Cloud.Logic.DomainModel;
using System;

namespace Cloud.Logic.Factories
{
    public class ProviderFactory : IProviderFactory
    {
        private readonly IDeployer _deployer;
        private readonly IDNS _dns;
        public ProviderFactory(IDeployer deployer, IDNS dns)
        {
            _deployer = deployer;
            _dns = dns;
        }

        public Provider Construct(string name, IApplication application, int threadPoolCapacity, bool isPublicServer = false, DomainModel.RateLimiter rateLimiter = null)
        {
            var provider = new Provider(name,Guid.NewGuid(), _dns.ReserveIp(name),rateLimiter, threadPoolCapacity);

            _deployer.Deploy(application, provider);

            return provider;
        }
    }
}
