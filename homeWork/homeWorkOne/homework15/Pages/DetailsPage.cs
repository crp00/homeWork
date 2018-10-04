using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace homework15
{
    public class DetailsPage : BasePage
    {
        public DetailsPage(IWebDriver driver) : base(driver)
        { }

        [FindsBy(How = How.XPath, Using = "//li[@name='characteristics']")]
        private IWebElement DeviceSpecsTab;

        [FindsBy(How = How.XPath, Using = "//table[@class='chars-t']/tbody")]
        private IWebElement SpecSection;

        //[FindsBy(How = How.XPath, Using = "//table[@class='chars-t']//a[@class='novisited']")]
        //private IList<IWebElement> DeviceInfo; //broken

        public void OpenSpecTab()
        {
            DeviceSpecsTab.Click();
        }

        public List<string> ReturnDeviceSpecs()
        {
            var result = new List<string>();

            foreach (var x in SpecSection.FindElements(By.XPath("//div[@class='chars-value']")))
            {
                result.Add(x.Text);
            }

            return result;
        }
    }
}