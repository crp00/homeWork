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

        [FindsBy(How = How.XPath, Using = "//table[@class='chars-t']//tr")]
        private IList<IWebElement> DeviceInfo;

        //private List<String> iPhone7Spec = new List<string>();
        //private List<String> iPhone7PlusSpec = new List<string>();

        //public List<string> IPhone7PlusSpec { get => iPhone7PlusSpec; set => iPhone7PlusSpec = value; }
        //public List<string> IPhone7Spec { get => iPhone7Spec; set => iPhone7Spec = value; }

        //private void SpecSaver(List<string> deviceSpecList)
        //{
        //    deviceSpecList = DeviceInfo.Select(x => x.Text).ToList();
        //}

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