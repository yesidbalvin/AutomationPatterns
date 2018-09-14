using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.Behaviors;
using OpenQA.Selenium;
using System.Reflection;

namespace Observer
{
    [TestClass]
    public class BaseTest
    {
        private readonly ITestExecutionSubject _currentTestExecutionSubject;
        private TestContext _testContextInstance;

        public BaseTest()
        {
            _currentTestExecutionSubject = new MsTestExecutionSubject();
            InitializeTestExecutionBehaviorObservers(_currentTestExecutionSubject);
            var memberInfo = MethodBase.GetCurrentMethod();
            _currentTestExecutionSubject.TestInstantiated(memberInfo);
        }

        public string BaseUrl { get; set; }
        
        public IWebDriver Browser { get; set; }

        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        public string TestName
        {
            get
            {
                return TestContext.TestName;
            }
        }

        [ClassInitialize]
        public static void OnClassInitialize(TestContext context)
        {
        }

        [ClassCleanup]
        public static void OnClassCleanup()
        {
        }

        [TestInitialize]
        public void CoreTestInit()
        {
            var memberInfo = GetCurrentExecutionMethodInfo();
            _currentTestExecutionSubject.PreTestInit(TestContext, memberInfo);
            TestInit();
            _currentTestExecutionSubject.PostTestInit(TestContext, memberInfo);
        }

        [TestCleanup]
        public void CoreTestCleanup()
        {
            var memberInfo = GetCurrentExecutionMethodInfo();
            _currentTestExecutionSubject.PreTestCleanup(TestContext, memberInfo);
            TestCleanup();
            _currentTestExecutionSubject.PostTestCleanup(TestContext, memberInfo);

        }

        public virtual void TestInit()
        {
        }

        public virtual void TestCleanup()
        {
        }

        private MethodInfo GetCurrentExecutionMethodInfo()
        {
            var memberInfo = GetType().GetMethod(TestContext.TestName);
            return memberInfo;
        }

        private void InitializeTestExecutionBehaviorObservers(ITestExecutionSubject currentTestExecutionSubject)
        {
            new AssociatedBugTestBehaviorObserver(currentTestExecutionSubject);
            new BrowserLaunchTestBehaviorObserver(currentTestExecutionSubject);
            new OwnerTestBehaviorObserver(currentTestExecutionSubject);
        }
    }
}
