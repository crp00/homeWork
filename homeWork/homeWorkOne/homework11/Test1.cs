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

            var searchKey = "macbook";
            var searchElement = driver.FindElement(By.XPath("//input[@type='search' and @id='multisearch']"));
            searchElement.SendKeys(searchKey);
            searchElement.Submit();

            var resultSet = new List<IWebElement>();

            resultSet = driver.FindElements(By.XPath("//div[@class='title - itm']/h5")).ToList();

            //foreach (IWebElement x in resultSet)
            //{
            //    resultFormatted.Add(x.ToString());
            //}

            //Assert.That(resultFormatted.Contains("macbook"));

            //driver.Quit();

            //titles = driver.FindElements(By.XPath("//div[@class='title - itm']/h5")).ToList();






        }
    }
}
