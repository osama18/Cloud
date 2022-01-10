using Cloud.Logic.DomainModel;
using Cloud.Logic.Factories;
using System.Threading.Tasks;

namespace Cloud.Logic.Services
{
    public abstract class BaseServerServices
    {
        public async Task<bool> Check(Server server)
        {
            var thread = ThreadPoolFactory.GetThreadPool(server);
            if (thread == null)
                return false;

            var result = thread.Check();

            thread?.Dispose();

            return result;
        }

        public async Task<Response> Get(Server server, Request request)
        {
            using (var thread = ThreadPoolFactory.GetThreadPool(server))
            {
                return thread.Get(request);
            }
        }
    }
}