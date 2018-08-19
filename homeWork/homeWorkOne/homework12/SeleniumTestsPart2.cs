using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace homework12
{
    [TestFixture]
    class SeleniumTestsPart2
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
            driver.Url = "http://toolsqa.com";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void ValidatePageIsOpenInNewTab_AndHasCorrectTitle()
        {
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-switch-windows/");
            driver.FindElement(By.XPath("//button[@onclick='newBrwTab()']")).Click();
            IReadOnlyCollection<string> tabHandles = driver.WindowHandles;
            driver.SwitchTo().Window(tabHandles.Last());

            var pageTitle = driver.Title;
            Assert.That(pageTitle.Equals("QA Automation Tools Tutorial"));
        }

        [Test]
        public void ValidateAlertOnPageHasCorrectText()
        {
            var expectedAllert = "Knowledge increases by sharing but not by saving. Please share this website with your friends and in your organization.";
            driver.Navigate().GoToUrl("http://toolsqa.com/automation-practice-switch-windows/");
            driver.FindElement(By.XPath("//button[@onclick='newAlert()']")).Click();
            IReadOnlyCollection<string> tabHandles = driver.WindowHandles;

            IAlert someAlert = driver.SwitchTo().Alert();
            var alertText = someAlert.Text;

            Assert.That(alertText.Equals(expectedAllert));
        }

        [Test]
        public void ValidateBrowserTitleAndFrameTitleAreCorrect()
        {
            var expectedTabTitle = "HTML Iframes";
            var expectedFrameTitle = "HTML Introduction";

            driver.Navigate().GoToUrl("https://www.w3schools.com/hTml/html_iframe.asp");
            var tabTitle = driver.Title;
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@src='default.asp']")));
            driver.FindElement(By.XPath("//a[@class='w3-right w3-btn' and @href='html_intro.asp']")).Click();
            var iframeTitle = driver.FindElement(By.XPath("//*[@id='main']/h1"));
            var frameTitle = iframeTitle.Text;

            Assert.That(tabTitle.Equals(expectedTabTitle) && frameTitle.Equals(expectedFrameTitle));
        }
    }
}
