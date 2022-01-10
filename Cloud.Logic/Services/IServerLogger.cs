using Cloud.Common.Logging;
using Cloud.Logic.DomainModel;
using System.Threading.Tasks;

namespace Cloud.Logic.Services
{
    public interface IServerLogger
    {
        Task CreateLog(Server server, LogLevel logLevel, string logmessage, params string[] parameters);
    }
}
