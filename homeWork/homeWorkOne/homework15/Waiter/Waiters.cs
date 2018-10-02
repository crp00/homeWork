using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace homework15
{
    public class Waiters
    {
        public void WaitForXpath(IWebDriver driver, int seconds, string xpath)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists((By.XPath(xpath))));
        }

        public void WaitForId(IWebDriver driver, int seconds, string id)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists((By.Id(id))));
        }
    }
}
