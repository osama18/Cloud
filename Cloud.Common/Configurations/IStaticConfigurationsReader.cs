namespace Cloud.Common.Configurations
{
    public interface IStaticConfigurationsReader
    {
        T Get<T>(string key);
    }
}