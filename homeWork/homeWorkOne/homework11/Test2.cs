using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace homework11
{
    [TestFixture]
    class Test2//div[@class='roww catalog-roww']//a/div/h5
    {
        public IWebDriver driver;

        public void WaiterByXpath(IWebDriver somedriver, int seconds, string xpath)
        {
            new WebDriverWait(somedriver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists((By.XPath(xpath))));
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.citrus.ua/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        [Category("refactored")]
        public void SearchForMacbook_ValidateProductTitles()
        {
            var searchKey = "MacBook";
            var sample = "//div[@class='roww catalog-roww']//div[@class='title-itm']";

            var searchElement = driver.FindElement(By.XPath("//input[@id='multisearch']"));
            searchElement.SendKeys(searchKey);
            searchElement.Submit();

            WaiterByXpath(driver,10,sample);

            var resultSet = driver.FindElements(By.XPath(sample)).ToList();

            var titleNames = resultSet.Select(x => x.Text).ToList();

            Assert.IsTrue(titleNames.All(i => i.Contains(searchKey)));
        }

        [Test]
        [Category("refactored")]
        public void GoToTvCategory_ApplyFilter_ValidateFilterIsApplied()
        {
            var checkbox = "//li[@class='flt-check']//span[contains(text(),'LG')]";

            driver.FindElement(By.XPath("//a[@title='TV']")).Click();

            WaiterByXpath(driver, 10, checkbox);

            driver.FindElement(By.XPath(checkbox)).Click();

            var filterObject = driver.FindElement(By.XPath("//span[@title='Бренд']"));
            var filterName = filterObject.Text;

            Assert.That(filterName.Contains("LG"));
        }

        [Test]
        [Category("refactored")]
        public void SaveNameAndPriceForFirstProduct_OpenPDP_ValidatePriceAndNameMatch()
        {
            var xpathGridPrice = "//span[@class='base-price']/span[@class='price-number']";
            var xpathGridName = "//div[@class='title-itm']/h5";
            var xpathPDPprice = "//a[@class='buy-general']//span[@class='price-number']";
            var xpathPDPname = "//h1[@class='cart-main-title']";

            driver.FindElement(By.XPath("//a[@title='TV']")).Click();

            WaiterByXpath(driver, 10, "//div[@class='catalog-card-container']");

            var gridPriceElement = driver.FindElement(By.XPath(xpathGridPrice));
            var gridNameElement = driver.FindElement(By.XPath(xpathGridName));
            var gridPrice = gridPriceElement.Text;
            var gridName = gridNameElement.Text;

            //driver.FindElement(By.XPath("//div[@class='catalog-card-container']")).Click();
            driver.FindElement(By.XPath("//div[@class='short-itm-desc']/a[@class='card-product-link']")).Click();

            WaiterByXpath(driver, 10, "//div[@class='description-cont']");

            var pdpPriceElement = driver.FindElement(By.XPath(xpathPDPprice));
            var pdpNameElement = driver.FindElement(By.XPath(xpathPDPname));
            var pdpPrice = pdpPriceElement.Text;
            var pdpName = pdpNameElement.Text;

            Assert.That(gridName.Equals(pdpName) && gridPrice.Equals(pdpPrice));
        }

        [Test]
        [Category("refactored")]
        public void GoToTV_ValidateFacetSearchCategoriesAreOrdered()
        {
            var xpathFacetFilters = "//div[@class='filter-itm']/h3";
            var expectedFilters = new List<string> { "Цена", "Акции и скидки", "Бренд", "Диагональ", "Разрешение", "Тип телевизора", "Smart TV", "Поддержка 3D", "Изогнутый экран", "Суммарная мощность динамиков", "Операционная система" };

            driver.FindElement(By.XPath("//a[@title='TV']")).Click();

            //new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath(xpathFacetFilters))));
            WaiterByXpath(driver, 10, xpathFacetFilters);

            var filterElements = driver.FindElements(By.XPath(xpathFacetFilters)).ToList();
            var filterValues = filterElements.Select(x => x.Text).ToList();

            Assert.That(filterValues.SequenceEqual(expectedFilters));
        }
    }
}
