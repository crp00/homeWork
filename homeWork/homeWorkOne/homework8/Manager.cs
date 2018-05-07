using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework8
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }
        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
}
