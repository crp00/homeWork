using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7.Task_1
{
    class Author
    {
        public string Name { get;  private set; }
        public string LastName { get; private set; }

        public Author(string _name, string _lastname)
        {
            Name = _name;
            LastName = _lastname;
        }

        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }
}
