using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace homework15.Actual_test
{
    [TestFixture]
    class TestsForBDD
    {
        private IWebDriver driver;
        private string mainUrl = "https://rozetka.com.ua/";

        [SetUp]
        public void SetupTests()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(mainUrl);
        }

        [TearDown]
        public void TearDownTests()
        {
            driver.Quit();
        }

        [Test]
        public void sometest()
        {
            //realisation
        }
    }
}
