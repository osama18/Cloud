using Cloud.Logic.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Logic.DeploymentTools
{
    class Deployer : IDeployer
    {
        public void Deploy(IApplication application, Provider provider)
        {
            provider.SetApplications(application);
        }
    }
}
