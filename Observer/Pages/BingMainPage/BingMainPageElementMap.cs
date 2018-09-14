using OpenQA.Selenium;

namespace Observer.Pages
{
    public class BingMainPageElementMap
    {
        private readonly IWebDriver _browser;

        public BingMainPageElementMap(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement SearchBox 
        {
            get
            {
                return _browser.FindElement(By.Id("sb_form_q"));
            }
        }

        public IWebElement GoButton 
        {
            get
            {
                return _browser.FindElement(By.Id("sb_form_go"));
            }
        }
       
        public IWebElement ResultsCountDiv
        {
            get
            {
                return _browser.FindElement(By.Id("b_tween"));
            }
        }
    }
}