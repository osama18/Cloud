using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Common.Configurations
{
    public interface IStaticConfigurationsReader
    {
        T Get<T>(string key);
    }
}
