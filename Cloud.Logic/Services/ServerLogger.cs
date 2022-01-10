using Cloud.Common.Logging;
using Cloud.Logic.DomainModel;
using System.Threading.Tasks;

namespace Cloud.Logic.Services
{
    public class ServerLogger : IServerLogger
    {
        public async Task CreateLog(Server server, LogLevel logLevel, string logmessage, params string[] parameters)
        {
            server.Logs.Add(new ServerLog
            {
                DateTimeUTC = System.DateTime.UtcNow,
                LogLevel = logLevel,
                Message = logmessage
            });
        }
    }
}