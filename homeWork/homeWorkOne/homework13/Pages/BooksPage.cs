using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace homework13
{
    public class BooksPage : BasePage
    {
        public BooksPage(IWebDriver driver) : base(driver)
        { }

        [FindsBy(How = How.XPath, Using = "//div/input[@class='field']")]
        public IWebElement categotySearch;

        [FindsBy(How = How.XPath, Using = "//form[@onsubmit='return false;']")]
        public IWebElement quickSearch;

        [FindsBy(How = How.ClassName, Using = "cell-navigation cell-navigation-tree")]
        public IWebElement facetMenu;

        [FindsBy(How = How.XPath, Using = "//div[@class='viewbox']/ul/li")]
        public IList<IWebElement> topAuthors;

        public BooksPage SearchForBook(string bookName)
        {
            categotySearch.SendKeys(bookName);
            return this;
        }
    }
}
