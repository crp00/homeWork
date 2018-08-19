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
    class TestsPageObject
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

            var gridItem = new List<string>();
            var pdpItem = new List<string>();

            somePage.ReturnFirstBookAuthorAndTitle(gridItem);
            somePage.OpenFirstItemPDP();
            somePage.ReturnPDPBookAuthorAndTitle(pdpItem);

            Assert.That(gridItem.Equals(pdpItem));
        }

        [Test]
        public void ValidateBookPricesInMaxMinRange()
        {
            var somePage = new BooksPage(driver);
            somePage.OpenFirstItemPDP();

            int[] priceRange = { };
            int[] suggestedPrices = { };

            somePage.ReturnExpectedMinAndMaxPrice(priceRange);
            somePage.OpenPDPPrices();
            somePage.ReturnSuggestedPricesOnPDP(suggestedPrices);

            Assert.IsTrue(suggestedPrices.All(x => x > priceRange.Min() && x < priceRange.Max()));
        }

        [Test]
        public void ValidateHeaderOptionsExistAndAreOrdered()
        {
            var somePage = new Header(driver);
            var expectedOptions = new List<string>() { "Кошик", "Мої списки", "Порівняння", "Вхід" };
            var actualOptions = new List<string>();

            somePage.EnableUALocalization();
            //somePage.ReturnHeaderNavOptions(actualOptions); //not working, returns empty collection

            var temp = driver.FindElements(By.XPath("//div[@class='header-nav cell-6']//span[@class='name']"));
            actualOptions = temp.Select(x => x.Text).ToList();

            Assert.IsTrue(actualOptions.SequenceEqual(expectedOptions));
        }
    }
}
