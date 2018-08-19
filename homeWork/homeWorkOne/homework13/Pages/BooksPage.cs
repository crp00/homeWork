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

        [FindsBy(How = How.XPath, Using = "//div/input[@class='field']")]
        private IWebElement categotySearch;

        //[FindsBy(How = How.XPath, Using = "//form[@onsubmit='return false;']")]
        //public IWebElement quickSearch;

        //[FindsBy(How = How.ClassName, Using = "cell-navigation cell-navigation-tree")]
        //public IWebElement facetMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='viewbox']/ul/li")]
        private IList<IWebElement> topAuthors;

        [FindsBy(How = How.XPath, Using = "//li[@class='product-item']/p/a")]
        private IWebElement firstBookTitleOnGrid;

        [FindsBy(How = How.XPath, Using = "//li[@class='product-item']/div[2]/a")]
        private IWebElement firstBookAuthorOnGrid;

        [FindsBy(How = How.XPath, Using = "//h1[@datatype='card-title']")]
        private IWebElement BookTitleOnPDP;

        [FindsBy(How = How.XPath, Using = "//div[@class='heading']/div/a")]
        private IWebElement BookAuthorOnPDP;

        [FindsBy(How = How.XPath, Using = "//span[@data-id='prices']/span")]
        private IWebElement PriceRangePDP;

        [FindsBy(How = How.XPath, Using = "//li[@data-id='prices']")]
        private IWebElement PDPPriceTab;

        [FindsBy(How = How.XPath, Using = "//a[@class='price-lg']//span[@class='value']")]
        private IList<IWebElement> PDPSuggestedPrices;

        public void SearchForBook(string bookName)
        {
            categotySearch.SendKeys(bookName);
        }

        public void ReturnFirstBookAuthorAndTitle( List<string> someList)
        {
            someList.Add(firstBookTitleOnGrid.Text);
            someList.Add(firstBookAuthorOnGrid.Text);
        }

        public void ReturnPDPBookAuthorAndTitle(List<string> someList)
        {
            someList.Add(BookTitleOnPDP.Text);
            someList.Add(BookAuthorOnPDP.Text);
        }

        public void ReturnExpectedMinAndMaxPrice(int[] someArray)
        {
            var tempValue = PriceRangePDP.Text;
            var tempArray = tempValue.Split('–').ToArray();
            someArray = tempArray.Select(x => int.Parse(x)).ToArray();
        }

        public void ReturnSuggestedPricesOnPDP(int[] someArray)
        {
            WaiterXpath(this._driver, 5, "//a[@class='price-lg']//span[@class='value']");
            someArray = PDPSuggestedPrices.Select(x => int.Parse(x.Text)).ToArray();
        }

        public void GetTopAuthors(string[] someArray)
        {
            someArray = topAuthors.Select(x => x.Text).ToArray();
        }

        public void OpenPDPPrices()
        {
            PDPPriceTab.Click();
        }

        public void OpenFirstItemPDP()
        {
            firstBookTitleOnGrid.Click();
        }
    }
}
