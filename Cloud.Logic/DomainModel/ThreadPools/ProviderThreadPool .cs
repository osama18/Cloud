namespace Cloud.Logic.DomainModel
{
    public class ProviderThreadPool : ServerThreadPool
    {
        private readonly Provider _provider;

        public ProviderThreadPool(Provider provider) : base(provider)
        {
            _provider = provider;
        }

        protected override void PerformDeepCheck()
        {
            //Check the app performance may be ?
        }

        protected override Response PerformGet(Request request)
        {
            return _provider.RunApplication(request);
        }
    }
}