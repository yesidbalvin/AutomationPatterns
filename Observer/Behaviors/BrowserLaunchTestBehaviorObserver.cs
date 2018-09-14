using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.Attributes;

namespace Observer.Behaviors
{
    public class BrowserLaunchTestBehaviorObserver : BaseTestBehaviorObserver
    {
        public BrowserLaunchTestBehaviorObserver(ITestExecutionSubject testExecutionSubject)
            : base(testExecutionSubject)
        {
        }

        public override void PreTestInit(TestContext context, MemberInfo memberInfo)
        {
            var browserType = GetExecutionBrowser(memberInfo);
            Driver.StartBrowser(browserType);
        }

        public override void PostTestCleanup(TestContext context, MemberInfo memberInfo)
        {
            Driver.StopBrowser();
        }

        private BrowserTypes GetExecutionBrowser(MemberInfo memberInfo)
        {
            var result = BrowserTypes.Firefox;
            var classBrowserType = GetExecutionBrowserClassLevel(memberInfo.DeclaringType);
            var methodBrowserType = GetExecutionBrowserMethodLevel(memberInfo);
            if (methodBrowserType != BrowserTypes.NotSet)
            {
                result = methodBrowserType;
            }
            else if (classBrowserType != BrowserTypes.NotSet)
            {
                result = classBrowserType;
            }
            return result;
        }

        private BrowserTypes GetExecutionBrowserMethodLevel(MemberInfo memberInfo)
        {
            var executionBrowserAttribute = memberInfo.GetCustomAttribute<ExecutionBrowserAttribute>(true);
            if (executionBrowserAttribute != null)
            {
                return executionBrowserAttribute.BrowserType;
            }
            return BrowserTypes.NotSet;
        }

        private BrowserTypes GetExecutionBrowserClassLevel(Type type)
        {
            var executionBrowserAttribute = type.GetCustomAttribute<ExecutionBrowserAttribute>(true);
            if (executionBrowserAttribute != null)
            {
                return executionBrowserAttribute.BrowserType;
            }
            return BrowserTypes.NotSet;
        }
    }
}
