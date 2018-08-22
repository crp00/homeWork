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
        private IWebElement CategotySearch;

        [FindsBy(How = How.XPath, Using = "//div[@class='viewbox']/ul/li")]
        private IList<IWebElement> TopAuthors;

        [FindsBy(How = How.XPath, Using = "//li[@class='product-item']/p/a")]
        private IWebElement FirstBookTitleOnGrid;

        [FindsBy(How = How.XPath, Using = "//li[@class='product-item']/div[2]/a")]
        private IWebElement FirstBookAuthorOnGrid;

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
            CategotySearch.SendKeys(bookName);
        }

        public void ReturnFirstBookAuthorAndTitle( List<string> someList)
        {
            someList.Add(FirstBookTitleOnGrid.Text);
            someList.Add(FirstBookAuthorOnGrid.Text);
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
            WaitForXpath(this._driver, 5, "//a[@class='price-lg']//span[@class='value']");
            someArray = PDPSuggestedPrices.Select(x => int.Parse(x.Text)).ToArray();
        }

        public void GetTopAuthors(string[] someArray)
        {
            someArray = TopAuthors.Select(x => x.Text).ToArray();
        }

        public void OpenPDPPrices()
        {
            PDPPriceTab.Click();
        }

        public void OpenFirstItemPDP()
        {
            FirstBookTitleOnGrid.Click();
        }
    }
}
