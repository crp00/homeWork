//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace homework11
//{
//    [TestFixture]
//    class TESTS
//    {
//        private IWebDriver _driver;

//        [SetUp]
//        public void TestSetup()
//        {
//            _driver = SeleniumWebDriverChromeDriver.Driver;
//            _driver.Url = "https://www.citrus.ua/";
//        }

//        [TearDown]
//        public void TestExit()
//        {
//            _driver.Quit();
//        }

//        [TestCase]
//        public void SearchForMacbookAndValidateResultHeaders()
//        {
//            var keyWord = "macbook";
//            var homePage = new HomePage(_driver);
//            var resultPage = new SearchResultsPage(_driver);

//            //homePage.SearchInput(keyWord);
//        }
//    }
//}
