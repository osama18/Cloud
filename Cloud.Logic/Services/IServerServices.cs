using Cloud.Logic.DomainModel;
using System;
using System.Threading.Tasks;

namespace Cloud.Logic.Services
{
    public interface IServerServices
    {
        Task<Response> Get(Server server, Request request);
        Task<bool> Check(Server server);
    }
}
