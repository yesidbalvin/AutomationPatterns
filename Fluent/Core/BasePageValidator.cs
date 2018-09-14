using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Core
{
    public class BasePageValidator<TS, TM, TV>
        where TS : BaseFluentPageSingleton<TS, TM, TV>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TS, TM, TV>, new()
    {
        protected TS PageInstance;

        public BasePageValidator(TS currentInstance)
        {
            PageInstance = currentInstance;
        }

        public BasePageValidator()
        {
        }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
    }
}
