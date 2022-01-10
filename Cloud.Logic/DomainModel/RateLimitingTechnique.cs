namespace Cloud.Logic.DomainModel
{
    public enum RateLimitingTechnique
    {
        TokenBucket,
        LeakyBucket,
        FixedWindow,
        SlidingWindow
    }
}