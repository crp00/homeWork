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
        [Test]
        public void MackBook_FromHomePageSearchMackbookAndValidateResults()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.citrus.ua/";

            var searchKey = "MacBook";
            var searchElement = driver.FindElement(By.XPath("//input[@type='search' and @id='multisearch']"));
            searchElement.SendKeys(searchKey);
            searchElement.Submit();

            var resultSet = new List<IWebElement>();
            var titleNames = new List<string>();

            System.Threading.Thread.Sleep(5000);

            resultSet = driver.FindElements(By.XPath("//div[@class='roww catalog-roww']//a/div/h5")).ToList();

            foreach (IWebElement x in resultSet)
            {
                titleNames.Add(x.Text);
            }

            Assert.IsTrue(titleNames.All(i => i.Contains(searchKey)));

            driver.Quit();
        }

        [TestCase]
        public void LG_FromHomePageGoToTVapplyLGfacetAndValidateElelement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.citrus.ua/";

            var firstElement = driver.FindElement(By.XPath("//a[@title='TV']"));

            firstElement.Click();

            System.Threading.Thread.Sleep(5000);

            var secondElement = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div[2]/aside/div/div[3]/ul/li[4]/label/span[1]")); //will refactor later

            secondElement.Click();

            var thirdElement = driver.FindElement(By.XPath("//span[@title='Бренд']"));

            var elementValue = thirdElement.Text;

            Assert.That(elementValue.Contains("LG"));

            driver.Quit();
        }

        [TestCase]
        public void PRDNAME_GoToTVandSaveFirstProductThenTRATATATA()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.citrus.ua/";

            var firstElement = driver.FindElement(By.XPath("//a[@title='TV']"));

            firstElement.Click();

            System.Threading.Thread.Sleep(5000);

            var productPriceElement1 = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div[2]/section/div[2]/div/div[1]/div/div/div[1]/div[4]/span[2]/span[1]")); //will refactor later
            var productNameElement1 = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div[2]/section/div[2]/div/div[1]/div/div/div[1]/a/div/h5"));

            var productPricePRE = productPriceElement1.Text;
            var productNamePRE = productNameElement1.Text;

            var secondElement = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div/div[2]/section/div[2]/div/div[1]/div/div/div[1]/a"));
            secondElement.Click();

            System.Threading.Thread.Sleep(5000);

            var productPriceElement2 = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div[2]/div[2]/section/div/div[2]/div/div[2]/div[1]/div[1]/a/span[1]/span[1]"));
            var productNameElement2 = driver.FindElement(By.XPath("//*[@id='__layout']/div/main/div[2]/h1"));

            var productPricePOST = productPriceElement2.Text;
            var productNamePOST = productNameElement2.Text;

            Assert.That(productPricePRE.Equals(productPricePOST) && productNamePRE.Equals(productNamePOST));

            driver.Quit();
        }

        [TestCase]
        public void FILTER_validateOrderOfTheFilterOnTVPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.citrus.ua/";

            var expectedFilters = new List<string> { "Цена", "Акции и скидки", "Бренд", "Диагональ", "Разрешение", "Тип телевизора", "Smart TV", "Поддержка 3D", "Изогнутый экран", "Суммарная мощность динамиков", "Операционная система" };

            var firstElement = driver.FindElement(By.XPath("//a[@title='TV']"));

            firstElement.Click();

            System.Threading.Thread.Sleep(5000);

            List<IWebElement> FilterElements = new List<IWebElement>();
            List<string> filters = new List<string>();

            FilterElements = driver.FindElements(By.XPath("//div[@class='filter-itm']/h3")).ToList();

            foreach (IWebElement x in FilterElements)
            {
                filters.Add(x.Text);
            }

            Assert.That(filters.SequenceEqual(expectedFilters));

            driver.Quit();
        }
    }
}
