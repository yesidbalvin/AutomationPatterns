using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_1_Approach.SecondApproach
{
    public class SearchEnginePageValidator
    {
        private readonly IWebDriver _browser;

        public SearchEnginePageValidator(IWebDriver browser)
        {
            _browser = browser;
        }

        protected SearchEngineElementMap Map
        {
            get
            {
                return new SearchEngineElementMap(_browser);
            }
        }

        public void ResultsCount(string expectedCount)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(Map.ResultsCountDiv.Text.Contains(expectedCount), 
                "The results DIV doesn't contains the specified text.");
        }
    }
}
