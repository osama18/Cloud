namespace Cloud.DAL.Model
{
    public enum RateLimitingTechnique
    {
        TokenBucket,
        LeakyBucket,
        FixedWindow,
        SlidingWindow
    }
}