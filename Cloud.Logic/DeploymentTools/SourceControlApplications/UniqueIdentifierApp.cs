using Cloud.Logic.DomainModel;
using Cloud.Logic.DomainModel.RequestsType;
using System;
using System.Threading.Tasks;

namespace Cloud.Logic.DeploymentTools.SourceControlApplications
{
    class UniqueIdentifierApp : IApplication
    {
        public Response Execute(Request request)
        {
            var response = new HttpResponse
            {
                Body = Guid.NewGuid().ToString(),
                StatusCode = StatusCode.Success
            };

            return response;
        }
    }
}
