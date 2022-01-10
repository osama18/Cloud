using Cloud.Common.Configurations;
using Cloud.Common.Logging;
using Cloud.Common.RanomNumers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Common.DNS
{
    public class DNS : IDNS
    {
        private IDictionary<string, string> _domainsDictionary = new Dictionary<string, string>();
        private readonly IStaticConfigurationsReader _staticConfigurationsReader;
        private readonly ILogger _logger;

        public DNS(IStaticConfigurationsReader staticConfigurationsReader, ILogger logger)
        {
            _staticConfigurationsReader = staticConfigurationsReader;
            _logger = logger;
        }

        public string GenerateNewIP(bool isPublic = true)
        {
            //for now I am handlin all as public
            var ip =  $"{RandomNumbersFactory.Construct(255, 1)}.{RandomNumbersFactory.Construct(255, 1)}.{RandomNumbersFactory.Construct(255, 1)}.{RandomNumbersFactory.Construct(255, 1)}";
            return ip;
        }

        public string ReserveIp(string domainname, bool isPublic = true)
        {
            int.TryParse(_staticConfigurationsReader.Get<string>("MaxGenerateIpTrials"), out int maxGenerateIpTrials);
            
            if (maxGenerateIpTrials == 0)
            {
                _logger.Log(LogLevel.Error, $"DNS has no configured max number of trials, default will be used");
                maxGenerateIpTrials = 1000000;
            }

            int numberofTrials = 0;
            var ip = GenerateNewIP(isPublic);
            while (!_domainsDictionary.ContainsKey(ip))
            {
                if (numberofTrials >= maxGenerateIpTrials)
                    return null;

                ip = GenerateNewIP(isPublic);
                numberofTrials++;
            }

            _domainsDictionary[ip] = domainname;
            return ip;
        }
        
    }
}
