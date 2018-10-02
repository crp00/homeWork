using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace homework15
{
    [Binding]
    public class BDD_Test_IPhone7Steps : BaseSetup
    {
        [Given(@"I have specs for (.*)")]
        public void GivenIHaveSpecsForIPhone(string device)
        {
            driver.Navigate().GoToUrl(MainUrl);

            var mainpage = new MainPage(driver);
            mainpage.SearchProduct(device);
            mainpage.OpenFirstProduct();

            var detailspage = new DetailsPage(driver);
            detailspage.OpenSpecTab();
            detailspage.SaveSpecs(device);

            var x = "shit";
        }
        
        [When(@"I compare the specs of devices")]
        public void WhenICompareTheSpecsOfDevices()
        {
            //do stuff
        }

        [Then(@"I output similar specs into file/console")]
        public void ThenIOutputSimilarSpecsIntoFileConsole()
        {
            //do stuff
        }
    }
}
