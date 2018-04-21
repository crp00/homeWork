using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class LegalPerson : IHasId
    {
        public string Id { get; }

        public LegalPerson(string id)
        {
            Id = id;
        }
    }
}
