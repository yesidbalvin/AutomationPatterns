

using OpenQA.Selenium;

namespace Decorator.Pages.SignInPage
{
    public class SignInPageMap : Core.BasePageElementMap
    {
        public IWebElement SignInButton
        {
            get
            {
                return Browser.FindElement(By.Id("signInSubmit"));
            }
        }

        public IWebElement PasswordInput
        {
            get
            {
                return Browser.FindElement(By.Id("ap_password"));
            }
        }

        public IWebElement ContinueButton
        {
            get
            {
                return Browser.FindElement(By.Id("continue"));
            }
        }

        public IWebElement EmailInput
        {
            get
            {
                return Browser.FindElement(By.Id("ap_email"));
            }
        }
    }
}