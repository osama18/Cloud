using System;
using System.Collections.Generic;

namespace Cloud.DAL.Model
{
    public abstract class Server : Entity
    {
        public int _ThreadPoolCapacity;
        public string IP { get; set; }
        public RateLimiter RateLimiter { get; set; }
        public IList<ServerLog> Logs { get; set; } = new List<ServerLog>();

    }
}
