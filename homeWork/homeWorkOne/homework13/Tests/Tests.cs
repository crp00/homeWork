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
        public void ValidateBookAuthorAndTitle_PDPvsGRID()
        {
            var somePage = new BooksPage(driver);

            var names = somePage.topAuthors.Select(x => x.Text).ToArray();

            var gridItem = new List<string>();
            var pdpItem = new List<string>();

            somePage.ReturnFirstBookAuthorAndTitle(gridItem);
            somePage.firstBookTitleOnGrid.Click();
            somePage.ReturnPDPBookAuthorAndTitle(pdpItem);

            Assert.That(gridItem.Equals(pdpItem));
        }

        [Test]
        public void ValidateBookPricesInMaxMinRange()
        {
            var somePage = new BooksPage(driver);
            somePage.firstBookTitleOnGrid.Click();

            int[] priceRange = { };
            int[] suggestedPrices = { };

            somePage.ReturnExpectedMinAndMaxPrice(priceRange);
            somePage.PDPPriceTab.Click();
            somePage.ReturnSuggestedPricesOnPDP(suggestedPrices);

            Assert.IsTrue(suggestedPrices.All(x => x > priceRange.Min() && x < priceRange.Max()));
        }
    }
}
