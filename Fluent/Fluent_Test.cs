using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fluent
{
    [TestClass]
    public class Fluent_Test
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void SearchImages()
        {
           var result =  Pages.BingMainPage
                .Instance
                .Navigate()
               .Search("facebook")
               .ClickImages()
               .Filter()
               .SetSize(Enums.Sizes.Small)
               .GetValidator();

            Assert.AreEqual("Pequeño", result);
            Thread.Sleep(5000);
        }
    }
}
