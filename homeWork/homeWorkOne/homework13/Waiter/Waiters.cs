using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace homework13
{
    public class Waiters
    {
        public void WaiterXpath(IWebDriver driver, int seconds, string xpath)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists((By.XPath(xpath))));
        }

        public void WaiterId(IWebDriver driver, int seconds, string id)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists((By.Id(id))));
        }
    }
}
