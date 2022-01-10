
using Cloud.Common.Logging;
using System;

namespace Cloud.DAL.Model
{
    public class ServerLog
    {
        public string Message { get; set; }
        public LogLevel LogLevel { get; set; }
        public DateTime DateTimeUTC { get; set; }
    }
}