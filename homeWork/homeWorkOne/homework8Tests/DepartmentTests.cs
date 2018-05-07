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

        [Test]
        [Category("Department")]
        public void Sort_MultipleEmpolyees_AreOrderedInList()
        {
            var someDepartment = new Department();
            var employee1 = new Programmer("Frank", "Garson", 25);
            var employee2 = new Programmer("Jade", "Garson", 35);
            var employee3 = new Programmer("Hamilton", "Garson", 45);

            someDepartment.Add(employee1);
            someDepartment.Add(employee2);
            someDepartment.Add(employee3);
            someDepartment.Sort();

            Assert.That(someDepartment.GetAll(),Is.Ordered);
        }

        [Test]
        [Category("Department")]
        public void Add_NewEmptyEmployee_ThrowsNullReferenceException()
        {
            //to add something here
        }
    }
}
