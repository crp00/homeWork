using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Citizen : Person, IHasId
    {
        public string Id { get; }

        public Citizen(string id)
        {
            Id = id;
        }

        public void ReturnFields()
        {
            Console.WriteLine(Id);
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
