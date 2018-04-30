using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_2
{
    class ExternalDisplay : IDisplay
    {
        public void Display()
        {
            Console.WriteLine("i am ExternalDisplay");
        }
    }
}
