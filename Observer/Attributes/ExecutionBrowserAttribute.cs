using System;

namespace Observer.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class ExecutionBrowserAttribute : Attribute
    {
        public ExecutionBrowserAttribute(BrowserTypes browser)
        {
            BrowserType = browser;
        }

        public BrowserTypes BrowserType { get; set; }
    }
}
