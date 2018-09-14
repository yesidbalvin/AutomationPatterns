using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Observer.Behaviors
{
    public class AssociatedBugTestBehaviorObserver : BaseTestBehaviorObserver
    {
        public AssociatedBugTestBehaviorObserver(ITestExecutionSubject testExecutionSubject) : base(testExecutionSubject)
        {
        }

        public override void PostTestCleanup(TestContext context, MemberInfo memberInfo)
        {
            var bugId = TryGetBugId(context, memberInfo);
            if (bugId.HasValue)
            {
                Console.WriteLine(string.Format("The test '{0}' is associated with bug id: {1}", context.TestName, bugId.Value));
            }
            else
            {
                Console.WriteLine(string.Format("The test '{0}' is not associated with any bug id.", context.TestName));
            }
        }

        private int? TryGetBugId(TestContext context, MemberInfo memberInfo)
        {
            var knownIssueAttribute = memberInfo.GetCustomAttribute<Attributes.KnownIssueAttribute>(true);
            var result = knownIssueAttribute == null ? null : (int?)knownIssueAttribute.BugId;
            return result;
        }
    }
}