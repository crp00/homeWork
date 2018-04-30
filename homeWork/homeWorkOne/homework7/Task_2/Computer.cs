using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_3
{
    class Computer 
    {
        private readonly IProcessor _processor;
        private readonly IDisplay _display;
        private readonly IInput _input;

        public Computer(IProcessor processor, IDisplay display, IInput input)
        {
            _processor = processor;
            _display = display;
            _input = input;
        }

        public void Work()
        {
            _processor.Process();
            _display.Display();
            _input.GetInput();
        }
    }
}
