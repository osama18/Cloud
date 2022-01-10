using Microsoft.Extensions.Configuration;
using System;

namespace Cloud.Common.Configurations
{
    public class ConfigurationsReader : IStaticConfigurationsReader
    {
        private readonly IConfigurationRoot configurationRoot;

        public ConfigurationsReader(IConfigurationRoot configurationRoot)
        {
            this.configurationRoot = configurationRoot;
        }

        public T Get<T>(string Key)
        {
            var value = configurationRoot[Key];

            if (value == null)
            {
                return default(T);
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}