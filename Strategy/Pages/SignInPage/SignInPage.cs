
namespace Strategy.Pages.SignInPage
{
    public class SignInPage : Core.BasePageSingleton<SignInPage, SignInPageMap>
    {
        public void Login(string email, string password)
        {
            Map.EmailInput.SendKeys(email);
            Map.ContinueButton.Click();
            Map.PasswordInput.SendKeys(password);
            Map.SignInButton.Click();
        }
    }
}