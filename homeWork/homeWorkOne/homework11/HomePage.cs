using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace homework11
{
    class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchInput => _driver.FindElement(By.XPath("//input[@type='search' and @id='multisearch']"));
    }
}
