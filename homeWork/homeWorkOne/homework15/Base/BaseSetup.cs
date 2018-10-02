using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace homework15
{
    public class BaseSetup : Waiters
    {
        public IWebDriver driver;
        private string mainUrl = "https://rozetka.com.ua/";

        public string MainUrl { get => mainUrl; set => mainUrl = value; }

        [BeforeScenario]
        public void TestSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(MainUrl);
        }

        [AfterScenario]
        public void TestClosure()
        {
            driver.Quit();
        } 
    }
}
