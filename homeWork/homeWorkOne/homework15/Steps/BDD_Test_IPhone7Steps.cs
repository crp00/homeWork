using System;
using TechTalk.SpecFlow;

namespace homework15.Steps
{
    [Binding]
    public class BDD_Test_IPhone7Steps
    {
        [Given(@"I am on rozetka main page")]
        public void GivenIAmOnRozetkaMainPage()
        {
            //do stuff
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
