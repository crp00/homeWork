using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_3_aggregation
{
    class Joystick : IInput
    {
        public void GetInput()
        {
            Console.WriteLine("I am Joystick");
        }
    }
}
