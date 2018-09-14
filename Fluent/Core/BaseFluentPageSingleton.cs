using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Core
{
    public abstract class BaseFluentPageSingleton<TS, TM> : ThreadSafeNestedContructorsBaseSingleton<TS>
        where TM : BasePageElementMap, new()
        where TS : BaseFluentPageSingleton<TS, TM>
    {
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
        protected void Navigate(string url = "")
        {
            Driver.Browser.Navigate().GoToUrl(string.Concat(url));
        }
    }
    public abstract class BaseFluentPageSingleton<TS, TM, TV> : BaseFluentPageSingleton<TS, TM>
        where TM : BasePageElementMap, new()
        where TS : BaseFluentPageSingleton<TS, TM, TV>
        where TV : BasePageValidator<TS, TM, TV>, new()
    {
        public TV Validate()
        {
            return new TV();
        }
    }
}
