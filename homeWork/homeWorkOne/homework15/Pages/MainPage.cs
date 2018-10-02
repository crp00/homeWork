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

        [FindsBy(How = How.XPath, Using = "//input[@name='text']")]
        private IWebElement SearchField;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn-link-i js-rz-search-button']")]
        private IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//div[@class='g-i-tile-i-title clearfix']")]
        private IWebElement FirstProduct;

        public void SearchProduct(string productName)
        {
            SearchField.SendKeys(productName);
            SearchButton.Click();
        }

        public void OpenFirstProduct()
        {
            FirstProduct.Click();
        }
    }
}
