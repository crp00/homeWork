using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace homework11
{
    class HomePageActions
    {
        private HomePage _homePage;

        public HomePageActions(IWebDriver driver)
        {
            _homePage = new HomePage(driver);
        }

        public void Search(string searchInput)
        {
            _homePage.SearchInput.SendKeys(searchInput);
            _homePage.SearchInput.Submit();
        }
    }
}
