namespace Cloud.DAL.Model
{
    public class StaticRateLimiter : RateLimiter
    {
        public int NumberOfActiveRequests { get; set; }
        public bool OnlyForSameIP { get; set; }
    }
}