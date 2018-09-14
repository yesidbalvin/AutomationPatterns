using Fluent.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Pages
{
    public class BingMainPageElementMap : BasePageElementMap
    {
        const string quotationMark = "\"";
        public IWebElement SearchBox
        {
            get
            {
                return Browser.FindElement(By.Id("sb_form_q"));
            }
        }

        public IWebElement GoButton
        {
            get
            {
                return Browser.FindElement(By.Id("sb_form_go"));
            }
        }

        public IWebElement ResultsCountDiv
        {
            get
            {
                return Browser.FindElement(By.Id("b_tween"));
            }
        }

        public IWebElement ImagesLink
        {
            get
            {
                return Browser.FindElement(By.LinkText("Imágenes"));
            }
        }
        public IWebElement Filter
        {
            get
            {
                return Browser.FindElement(By.LinkText("Filtro"));
            }
        }
        public IWebElement Sizes
        {
            get
            {
                return BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div/ul/li/span/span[text() = 'Tamaño de la imagen']")));
                //return Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Tamaño de la imagen']"));

            }
        }
        public IWebElement AllSize
        {
            get
            {
                //return BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(String.Concat("//*[@id=", quotationMark, "ftrB", quotationMark, "]/ul/li[1]/div/div/a[2]/span"))));
                return Browser.FindElement(By.XPath(String.Concat("//*[@id=", quotationMark, "ftrB", quotationMark, "]/ul/li[1]/div/div/a[2]/span")));
            }
        }
        //public SelectElement Sizes
        // {
        //     get
        //     {
        //        return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Tamaño de la imagen']")));

        //     }
        // }

        public SelectElement Color
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Color']")));
            }
        }

        public SelectElement Type
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Tipo']")));
            }
        }

        public SelectElement Layout
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Diseño']")));
            }
        }

        public SelectElement People
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Gente']")));
            }
        }

        public SelectElement Date
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Fecha']")));
            }
        }

        public SelectElement License
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.XPath("//div/ul/li/span/span[text() = 'Licencia']")));
            }
        }
        public IWebElement ImageSize
        {
            get
            {

                return Browser.FindElement(By.XPath(String.Concat("//*[@id=", quotationMark, "ftrB", quotationMark, " ]/ul/li[1]/span")));
                //return Browser.FindElement(By.XPath(String.Concat("//*[@id=", quotationMark, "mmComponent_images_1", quotationMark, "]/ul[1]/li[1]/div/div[1]/a")));
            }
        }
    }
}
