using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace homework11
{
    class SearchResultsPage
    {
        private IWebDriver _driver;

        public SearchResultsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement[] ItemTitles => _driver.FindElements(By.XPath("//div[@class='title - itm']/h5")).ToArray();
    }
}
