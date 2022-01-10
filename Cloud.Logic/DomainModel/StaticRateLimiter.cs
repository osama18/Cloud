namespace Cloud.Logic.DomainModel
{
    public class StaticRateLimiter : RateLimiter
    {
        public int NumberOfActiveRequests { get; set; }
        public bool OnlyForSameIP { get; set; }
    }
}