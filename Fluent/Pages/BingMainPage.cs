using Fluent.Core;
using Fluent.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Pages
{
    public class BingMainPage : BaseFluentPageSingleton<BingMainPage, BingMainPageElementMap, BingMainPageValidator>
    {
        private BingMainPage()
        {

        }
        public new  BingMainPage Navigate(string url = "http://www.bing.com/")
        {
            base.Navigate(url);
            return this;
        }

        public BingMainPage Search(string textToType)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(textToType);
            Map.GoButton.Click();
            return this;
        }

        public BingMainPage ClickImages()
        {
            Map.ImagesLink.Click();
            return this;
        }
        public BingMainPage Filter()
        {
            Map.Filter.Click();
            return this;
        }
        public BingMainPage SetSize(Sizes size)
        {
            Map.Sizes.Click();
            Map.AllSize.Click();
            //Map.Sizes.SelectByIndex((int)size);
            return this;
        }

        public BingMainPage SetColor(Colors color)
        {
            Map.Color.SelectByIndex((int)color);
            return this;
        }

        public BingMainPage SetTypes(Types type)
        {
            Map.Type.SelectByIndex((int)type);
            return this;
        }

        public BingMainPage SetLayout(Layouts layout)
        {
            Map.Layout.SelectByIndex((int)layout);
            return this;
        }

        public BingMainPage SetPeople(People people)
        {
            Map.People.SelectByIndex((int)people);
            return this;
        }

        public BingMainPage SetDate(Dates date)
        {
            Map.Date.SelectByIndex((int)date);
            return this;
        }

        public BingMainPage SetLicense(Licenses license)
        {
            Map.License.SelectByIndex((int)license);
            return this;
        }

        public string GetValidator()
        {
            return Map.ImageSize.Text;
        }
    }
}
