using Cloud.Logic.DomainModel;

namespace Cloud.Logic.DeploymentTools
{
    internal class Deployer : IDeployer
    {
        public void Deploy(IApplication application, Provider provider)
        {
            provider.SetApplications(application);
        }
    }
}