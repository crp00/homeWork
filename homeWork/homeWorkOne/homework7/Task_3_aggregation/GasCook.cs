using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_3_aggregation
{
    class GasCook : ICook
    {
        public void Cook()
        {
            Console.WriteLine("I do fries with GAS");
        }
    }
}
