using Fluent.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Pages
{
    public class BingMainPageValidator : BasePageValidator<BingMainPage, BingMainPageElementMap, BingMainPageValidator>
    {
        public BingMainPage ResultsCount(string expectedCount)
        {
            Assert.IsTrue(Map.ResultsCountDiv.Text.Contains(expectedCount), "The results DIV doesn't contains the specified text.");
            return PageInstance;
        }
    }
}
