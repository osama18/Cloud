using Cloud.Logic.DomainModel;
using System.Threading.Tasks;

namespace Cloud.Logic.DeploymentTools
{
    public interface IDeployer
    {
        void Deploy(IApplication application, Provider provider);
    }
}