using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace homework11
{
    [TestFixture]
    public class Test1
    {
        [TestCase]
        public void Sometest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.citrus.ua/";

            var searchElement = driver.FindElement(By.XPath("//input[@type='search' and @id='multisearch']"));
            searchElement.SendKeys("macbook");
            searchElement.Submit();

            Assert.That(driver.Url.Contains("macbook"));

            driver.Close();




        }
    }
}
