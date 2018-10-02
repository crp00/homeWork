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
    [Binding]
    public class BDD_Test_IPhone7Steps : BaseSetup
    {
        [Given(@"I am on rozetka main page")]
        public void GivenIAmOnRozetkaMainPage()
        {
            var mainpage = new MainPage(driver);
        }
        
        [When(@"I enter search value (.*) and open first details page")]
        public void WhenSearchThenOpenFirstPDP(string itemName)
        {
            //do stuff
        }

        [When(@"I open details tab")]
        public void WhenOpenDetailsTab()
        {
            //do stuff
        }

        [Then(@"the details are corresponding to (.*)")]
        public void DetailsAreCorrespondingToProduct(string itemName)
        {
            //do stuff
        }
    }
}
