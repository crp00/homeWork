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
    class Test2
    {
        //IWebDriver driver = new ChromeDriver();
        public IWebDriver driver;

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
            var sample = "//div[@class='roww catalog-roww']//a/div/h5";

            var searchElement = driver.FindElement(By.XPath("//input[@type='search' and @id='multisearch']"));
            searchElement.SendKeys(searchKey);
            searchElement.Submit();

            //System.Threading.Thread.Sleep(5000);
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath(sample))));

            var resultSet = driver.FindElements(By.XPath(sample)).ToList();

            var titleNames = resultSet.Select(x => x.Text).ToList();

            Assert.IsTrue(titleNames.All(i => i.Contains(searchKey)));
        }

        [Test]
        [Category("refactored")]
        public void GoToTvCategory_ApplyFilter_ValidateFilterIsApplied()
        {
            var crazyXpath = "//*[@id='__layout']/div/main/div/div[2]/aside/div/div[3]/ul/li[4]/label/span[1]";

            driver.FindElement(By.XPath("//a[@title='TV']")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath(crazyXpath))));

            driver.FindElement(By.XPath(crazyXpath)).Click();

            var filterObject = driver.FindElement(By.XPath("//span[@title='Бренд']"));
            var filterName = filterObject.Text;

            Assert.That(filterName.Contains("LG"));
        }

        [Test]
        [Category("refactored")]
        public void SaveNameAndPriceForFirstProduct_OpenPDP_ValidatePriceAndNameMatch()
        {
            var xpathGridPrice = "//*[@id='__layout']/div/main/div/div[2]/section/div[2]/div/div[1]/div/div/div[1]/div[4]/span[2]/span[1]";
            var xpathGridName = "//*[@id='__layout']/div/main/div/div[2]/section/div[2]/div/div[1]/div/div/div[1]/a/div/h5";
            var xpathPDPprice = "//*[@id='__layout']/div/main/div[2]/div[2]/section/div/div[2]/div/div[2]/div[1]/div[1]/a/span[1]/span[1]";
            var xpathPDPname = "//*[@id='__layout']/div/main/div[2]/h1";

            var xpathOpenPDP = "//*[@id='__layout']/div/main/div/div[2]/section/div[2]/div/div[1]/div/div/div[1]/a";

            driver.FindElement(By.XPath("//a[@title='TV']")).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath(xpathGridPrice))));

            var gridPriceElement = driver.FindElement(By.XPath(xpathGridPrice));
            var gridNameElement = driver.FindElement(By.XPath(xpathGridName));
            var gridPrice = gridPriceElement.Text;
            var gridName = gridNameElement.Text;

            driver.FindElement(By.XPath(xpathOpenPDP)).Click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath(xpathPDPprice))));

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

            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists((By.XPath(xpathFacetFilters))));

            var filterElements = driver.FindElements(By.XPath(xpathFacetFilters)).ToList();
            var filterValues = filterElements.Select(x => x.Text).ToList();

            Assert.That(filterValues.SequenceEqual(expectedFilters));
        }
    }
}
