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

            //System.Threading.Thread.Sleep(5000);

            WaitForXpath(driver,10, "//table[@class='chars-t']//a[@class='novisited']");

            switch (device)
            {
                case "iPhone 7":
                    ScenarioContext.Current["iPhone7SpecObject"] = detailspage.ReturnDeviceSpecs();
                    break;
                case "iPhone 7 Plus":
                    ScenarioContext.Current["iPhone7PlusSpecObject"] = detailspage.ReturnDeviceSpecs();
                    break;
            }
        }
        
        [When(@"I compare the specs of devices")]
        public void WhenICompareTheSpecsOfDevices()
        {
            var iPhone7SDO = ScenarioContext.Current["iPhone7SpecObject"];
            var iPhone7PSDO = ScenarioContext.Current["iPhone7PlusSpecObject"];
        }

        [Then(@"I output similar specs into file/console")]
        public void ThenIOutputSimilarSpecsIntoFileConsole()
        {
            //do stuff
        }
    }
}
