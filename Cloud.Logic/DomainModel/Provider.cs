using System;
using System.Collections.Generic;

namespace Cloud.Logic.DomainModel
{
    public class Provider : Server
    {
        private IApplication _application;

        public Provider(string name,
                Guid id,
                string ip,
                RateLimiter rateLimiter,
                int threadPoolCapacity) : base(threadPoolCapacity)
        {
            FriendlyName = name;
            IP = ip;
            Id = id;
            RateLimiter = rateLimiter;
        }

        internal void SetApplications(IApplication application)
        {
            _application = application;
        }

        //should introduce runtime enviornment actor here instead of rund directly
        internal Response RunApplication(Request request)
        {
            return _application.Execute(request);
        }
    }
}
