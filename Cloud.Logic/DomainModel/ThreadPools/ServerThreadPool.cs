using System;

namespace Cloud.Logic.DomainModel
{
    public abstract class ServerThreadPool : IDisposable
    {
        private readonly Server _server;

        public ServerThreadPool(Server server)
        {
            _server = server;
        }

        //For purpose of sumulation I will use random state of 90% alive
        private bool IsUpAndRunning() => (new Random().Next(0, 100) > 90);

        public bool Check()
        {
            if (!IsUpAndRunning())
                return false;

            PerformDeepCheck();

            return true;
        }

        public Response Get(Request request)
        {
            //We can use this abstraction to log matrix for example
            return PerformGet(request);
        }

        protected abstract Response PerformGet(Request request);

        protected abstract void PerformDeepCheck();

        public void Dispose()
        {
            _server.ReleaseThread();
        }
    }
}