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
            var titleNames = new List<string>();

            System.Threading.Thread.Sleep(5000);

            resultSet = driver.FindElements(By.XPath("//div[@class='title-itm']/h5")).ToList();

            //var resultSet = driver.FindElements(By.XPath("//div[@class='title-itm']/h5")).ToString().ToList();

            //Assert.That(resultSet.Contains(searchKey));

            driver.Quit();







        }
    }
}
