using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace homework15.Base
{
    public class BaseSetup
    {
        [BeforeScenario]
        public void TestSetup()
        {
            //setup
        }

        [AfterScenario]
        public void TestClosure()
        {
            //close
        } 
    }
}
