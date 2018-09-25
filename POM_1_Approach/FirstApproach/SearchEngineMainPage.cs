using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace POM_1_Approach.FirstApproach
{
    class SearchEngineMainPage
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://www.bing.com";

        public SearchEngineMainPage(IWebDriver browser)
        {
            this.driver = browser;
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Id, Using = "sb_form_q")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Id, Using = "sb_form_go")]
        public IWebElement GoButton { get; set; }

        [FindsBy(How = How.Id, Using = "sb_count")]
        public IWebElement ResultsCountDiv { get; set; }

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }

        public void Search(string textToType)
        {
            this.SearchBox.Clear();
            this.SearchBox.SendKeys(textToType);
            this.GoButton.Click();
        }
        ///Deprecated
        //public void ValidateResultsCount(string expectedCount)
        //{
        //    Assert.IsTrue(this.ResultsCountDiv.Text.Contains(expectedCount), "The results DIV doesn't contains the specified text.");
        //}
    }
}
