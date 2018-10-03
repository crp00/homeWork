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
    public class DetailsPage : BasePage
    {
        public DetailsPage(IWebDriver driver) : base(driver)
        { }

        [FindsBy(How = How.XPath, Using = "//li[@name='characteristics']")]
        private IWebElement DeviceSpecsTab;

        [FindsBy(How = How.XPath, Using = "//table[@class='chars-t']//a[@class='novisited']")]
        private IList<IWebElement> DeviceInfo;

        public void OpenSpecTab()
        {
            DeviceSpecsTab.Click();
        }

        public IList<IWebElement> ReturnDeviceSpecs()
        {
            return DeviceInfo;
        }
    }
}