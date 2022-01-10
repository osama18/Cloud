using Cloud.Logic.DomainModel;

namespace Cloud.Logic.DeploymentTools
{
    public interface IDeployer
    {
        void Deploy(IApplication application, Provider provider);
    }
}