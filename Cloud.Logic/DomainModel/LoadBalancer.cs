using Cloud.Common.DataStrucures;
using System;
using System.Collections.Generic;

namespace Cloud.Logic.DomainModel
{
    public class LoadBalancer : Server
    {
        public LoadBalancer(string name,
                Guid id,
                string ip,
                RateLimiter rateLimiter,
                ServerSelectionStrategy serverSelectionStrategy,
                int threadPoolCapacity) : base(threadPoolCapacity)
        {
            FriendlyName = name;
            Id = id;
            IP = ip;
            RateLimiter = rateLimiter;
            ServerSelectionStrategy = serverSelectionStrategy;
        }

        public CountMap InactiveServerTracker { get; set; } = new CountMap();
        public IList<Server> RegisteredActiveServers { get; set; } = new List<Server>();
        public IList<Server> RegisteredInActiveServers { get; set; } = new List<Server>();
        public ServerSelectionStrategy ServerSelectionStrategy { get; set; }
    }
}