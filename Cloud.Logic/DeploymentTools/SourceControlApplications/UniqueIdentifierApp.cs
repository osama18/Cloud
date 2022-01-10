using Cloud.Logic.DomainModel;
using Cloud.Logic.DomainModel.RequestsType;
using System;

namespace Cloud.Logic.DeploymentTools.SourceControlApplications
{
    internal class UniqueIdentifierApp : IApplication
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