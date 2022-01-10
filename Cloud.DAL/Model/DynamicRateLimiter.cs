namespace Cloud.DAL.Model
{
    public class DynamicRateLimiter : RateLimiter
    {
        public DynamicRateLimiterType DynamicRateLimiterType { get; set; }
    }
}