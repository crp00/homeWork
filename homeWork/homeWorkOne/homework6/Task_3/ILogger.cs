﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6.Task_3
{
    interface ILogger
    {
        void ConsoleLogger(string log);
        void FileLogger(string log);
    }
}
