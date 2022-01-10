namespace Cloud.Logic.DomainModel
{
    public class DynamicRateLimiter : RateLimiter
    {
        public DynamicRateLimiterType DynamicRateLimiterType { get; set; }
    }
}