namespace Decorator.Core
{
    public abstract class BasePageSingleton<TS, TM> : ThreadSafeLazyBaseSingleton<TS>
        where TM : BasePageElementMap, new()
        where TS : BasePageSingleton<TS, TM>, new()
    {
        public BasePageSingleton()
        {
        }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        public virtual void Navigate(string url = "")
        {
            Driver.Browser.Navigate().GoToUrl(string.Concat(url));
        }
    }

    public abstract class BasePageSingleton<TS, TM, TV> : BasePageSingleton<TS, TM>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
        where TS : BasePageSingleton<TS, TM, TV>, new()
    {
        public TV Validate()
        {
            return new TV();
        }
    }
}