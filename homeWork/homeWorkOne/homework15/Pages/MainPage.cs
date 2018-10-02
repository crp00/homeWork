using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace homework15
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        { }

        [FindsBy(How = How.XPath, Using = "//div/input[@class='field']")]
        private IWebElement CategotySearch;

        public void SearchProduct()
        {
            //do stuff
        }
    }
}
