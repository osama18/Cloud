namespace Cloud.DAL.Model
{
    public abstract class RateLimiter
    {
        public RateLimitingStrategy RateLimitingStrategy { get; set; }
        public RateLimitingTechnique RateLimitingTechnique { get; set; }
    }
}