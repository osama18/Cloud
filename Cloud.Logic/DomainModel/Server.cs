using System.Collections.Generic;

namespace Cloud.Logic.DomainModel
{
    public abstract class Server : Entity
    {
        public Server(int threadPoolCapacity)
        {
            _ThreadPoolCapacity = threadPoolCapacity;
        }

        protected int _currentThreadsCount;

        protected readonly int _ThreadPoolCapacity;
        public string IP { get; set; }
        public RateLimiter RateLimiter { get; set; }
        public IList<ServerLog> Logs { get; set; } = new List<ServerLog>();

        private bool HasMoreThreads() => _currentThreadsCount < _ThreadPoolCapacity;

        public bool GetThread()
        {
            if (!HasMoreThreads())
            {
                _currentThreadsCount++;
                return true;
            }

            return false;
        }

        public void ReleaseThread()
        {
            _currentThreadsCount--;
        }
    }
}