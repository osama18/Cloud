using Cloud.Common.Logging;
using System;

namespace Cloud.Logic.DomainModel
{
    public class ServerLog
    {
        public string Message { get; set; }
        public LogLevel LogLevel { get; set; }
        public DateTime DateTimeUTC { get; set; }
    }
}