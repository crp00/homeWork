using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace homework13
{
    public class BooksPage : BasePage
    {
        public BooksPage(IWebDriver driver) : base(driver)
        { }

        private void waiterXpath(IWebDriver driver ,int seconds, string xpath)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementExists((By.XPath(xpath))));
        }

        [FindsBy(How = How.XPath, Using = "//div/input[@class='field']")]
        public IWebElement categotySearch;

        [FindsBy(How = How.XPath, Using = "//form[@onsubmit='return false;']")]
        public IWebElement quickSearch;

        [FindsBy(How = How.ClassName, Using = "cell-navigation cell-navigation-tree")]
        public IWebElement facetMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='viewbox']/ul/li")]
        public IList<IWebElement> topAuthors;

        [FindsBy(How = How.XPath, Using = "//li[@class='product-item']/p/a")]
        public IWebElement firstBookTitleOnGrid;

        [FindsBy(How = How.XPath, Using = "//li[@class='product-item']/div[2]/a")]
        public IWebElement firstBookAuthorOnGrid;

        [FindsBy(How = How.XPath, Using = "//h1[@datatype='card-title']")]
        private IWebElement BookTitleOnPDP;

        [FindsBy(How = How.XPath, Using = "//div[@class='heading']/div/a")]
        private IWebElement BookAuthorOnPDP;

        [FindsBy(How = How.XPath, Using = "//span[@data-id='prices']/span")]
        private IWebElement PriceRangePDP;

        [FindsBy(How = How.XPath, Using = "//li[@data-id='prices']")]
        public IWebElement PDPPriceTab;

        [FindsBy(How = How.XPath, Using = "//a[@class='price-lg']//span[@class='value']")]
        private IList<IWebElement> PDPSuggestedPrices;

        public BooksPage SearchForBook(string bookName)
        {
            categotySearch.SendKeys(bookName);
            return this;
        }

        public BooksPage ReturnFirstBookAuthorAndTitle( List<string> someList)
        {
            someList.Add(firstBookTitleOnGrid.Text);
            someList.Add(firstBookAuthorOnGrid.Text);
            return this;
        }

        public BooksPage ReturnPDPBookAuthorAndTitle(List<string> someList)
        {
            someList.Add(BookTitleOnPDP.Text);
            someList.Add(BookAuthorOnPDP.Text);
            return this;
        }

        public BooksPage ReturnExpectedMinAndMaxPrice(int[] someArray)
        {
            var tempValue = PriceRangePDP.Text;
            var tempArray = tempValue.Split('–').ToArray();
            someArray = tempArray.Select(x => int.Parse(x)).ToArray();
            return this;
        }

        public BooksPage ReturnSuggestedPricesOnPDP(int[] someArray)
        {
            waiterXpath(this._driver, 5, "//a[@class='price-lg']//span[@class='value']");
            someArray = PDPSuggestedPrices.Select(x => int.Parse(x.Text)).ToArray();
            return this;
        }
    }
}
