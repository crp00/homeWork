using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8Tests
{
    using NUnit.Framework;
    using System;
    using homework8;

    [TestFixture]

    class DepartmentTests
    {
        [Test]
        [Category("Department")]
        public void Add_newEmployee_SaveToList()
        {
            //arrange
            var someEmployee1 = new Employee("John", "Doe", 34);
            //act
            //assert
        }

        [Test]
        [Category("Department")]
        public void Add_EmptyEmployee_SaveToList()
        {

        }
    }
}
