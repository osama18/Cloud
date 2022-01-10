using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Common.Logging
{
    public interface ILogger
    {
        Task Log(LogLevel logLevel, string logmessage, params string[] parameters);
    }
}
