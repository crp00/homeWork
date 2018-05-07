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
        public void Add_newManager_SaveToList()
        {
            //arrange
            var someManager1 = new Manager("John", "Doel", 34);
            var someDepartment1 = new Department();

            //act
            someDepartment1.Add(someManager1);

            //assert
            Assert.That(someDepartment1.GetAll(),Does.Contain(someManager1));
        }

        [Test]
        [Category("Department")]
        public void Add_newProgrammer_SaveToList()
        {
            var someProgrammer1 = new Programmer("Felix", "Davis", 41);
            var someDepartment1 = new Department();

            someDepartment1.Add(someProgrammer1);
            Assert.That(someDepartment1.GetAll(), Does.Contain(someProgrammer1));
        }

        [Test]
        [Category("Department")]
        public void GetAll_InvokeEmptyList_ReturnEmpty()
        {
            var someDepartment1 = new Department();

            Assert.That(someDepartment1.GetAll(),Is.Empty);
        }
    }
}
