﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_3
{
    class Oven : IBake
    {
        public void Bake()
        {
            Console.WriteLine("I bake chocolate cakes");
        }
    }
}
