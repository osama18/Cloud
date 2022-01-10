using System;
namespace Cloud.Common.RanomNumers
{
    public static class RandomNumbersFactory 
    {
        public static int Construct(int max, int min = 0)
        {
            return new Random().Next(min, max);
        }
    }
}
