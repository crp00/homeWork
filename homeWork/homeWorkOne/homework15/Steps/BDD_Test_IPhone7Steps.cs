using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;

namespace homework15
{
    [Binding]
    public class BDD_Test_IPhone7Steps : BaseSetup
    {
        [Given(@"I have specs for (.*)")]
        public void GivenIHaveSpecsForIPhone(string device)
        {
            driver.Navigate().GoToUrl(MainUrl);

            var test1 = new List<string>();
            var test2 = new List<string>();

            var mainpage = new MainPage(driver);
            mainpage.SearchProduct(device);
            mainpage.OpenFirstProduct();

            var detailspage = new DetailsPage(driver);
            detailspage.OpenSpecTab();

            //System.Threading.Thread.Sleep(8000);

            WaitForXpath(driver, 10, "//table[@class='chars-t']/tbody//div[@class='chars-value']");

            switch (device)
            {
                case "iPhone 7":
                    test1 = detailspage.ReturnDeviceSpecs();
                    ScenarioContext.Current.Add("Iphone7", test1);
                    break;
                case "iPhone 7 Plus":
                    test2 = detailspage.ReturnDeviceSpecs();
                    ScenarioContext.Current.Add("Ipone7Plus", test2);
                    break;
            }
        }
        
        [When(@"I compare the specs of devices")]
        public void WhenICompareTheSpecsOfDevices()
        {
            var iPhone7Props = ScenarioContext.Current.Get<List<string>>("Iphone7");
            var iPhone7PlusProps = ScenarioContext.Current.Get<List<string>>("Ipone7Plus");

            var matches = iPhone7Props.Intersect(iPhone7PlusProps).ToList();

            ScenarioContext.Current.Add("Results", matches);
        }

        [Then(@"I output similar specs into file/console")]
        public void ThenIOutputSimilarSpecsIntoFileConsole()
        {
            var output = ScenarioContext.Current.Get<List<string>>("Results");

            foreach (var spec in output)
            {
                Console.WriteLine(spec);
            }
        }
    }
}
