using Cloud.Common.RanomNumers;
using Cloud.Logic.DomainModel;
using Cloud.Logic.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cloud.Logic.Strategies
{
    public class RandomSelectionStrategy : BaseSelectionStrategy
    {
        
        public RandomSelectionStrategy(LoadBalancer loadBalancer) : base(loadBalancer)
        {
        }

        protected override int GetNextCustomeIndex(int numberOfServers)
        {
            return RandomNumbersFactory.Construct(numberOfServers);
        }
    }
}
