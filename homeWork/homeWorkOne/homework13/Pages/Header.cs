using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace homework13
{
    public class Header : BasePage
    {
        public Header(IWebDriver driver) : base(driver)
        { }

        [FindsBy(How = How.XPath, Using = "//div[@class='header-nav cell-6']//span[@class='name']")]
        private IList<IWebElement> HeaderNavOptions;

        [FindsBy(How = How.XPath, Using = "//span[@data-language='uk']")]
        private IWebElement ukLocal;

        public void ReturnHeaderNavOptions(List<string> someList) 
        {
            someList = HeaderNavOptions.Select(x => x.Text).ToList();
        }

        public void EnableUALocalization()
        {
            ukLocal.Click();
        }
    }
}
