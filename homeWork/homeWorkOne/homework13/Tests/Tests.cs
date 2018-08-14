using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using homework13;

namespace homework13
{
    [TestFixture]
    class Tests
    {
        private IWebDriver driver;
        private string mainUrl = "https://hotline.ua/knigi/";

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
        public void SomeTest()
        {
            var somePage = new BooksPage(driver);

            var names = somePage.topAuthors.Select(x => x.Text).ToArray();

            var gridItem = new List<string>();

            somePage.ReturnFirstBookAuthorAndTitle(gridItem);

            somePage.firstBookTitleOnGrid.Click();

            var shit = string.Empty;
        }
    }
}
