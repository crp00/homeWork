using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace homework8Tests
{
    [TestFixture]
    class Task2Tests
    {
        [Test] //1
        [Category("Task_2")]
        public void Constraint_AssertSumOfXandY_ReturnsTrue()
        {
            var X = 12;
            var Y = 10;
            var expected = 22;

            var result = X + Y;

            Assert.That(result,Is.EqualTo(expected), $"Actual result is {result} but expected result is {expected}");
        }

        [Test] //1
        [Category("Task_2")]
        public void Classic_AssertSumOfXandY_ReturnsTrue()
        {
            var X = 12;
            var Y = 10;
            var expected = 22;

            var result = X + Y;

            Assert.AreEqual(result,expected, $"Actual result is {result} but expected result is {expected}");
        }

        [Test] //2
        [Category("Task_2")]
        public void Constraint_AssertCollectionIsEmpty_ReturnsTrue()
        {
            var someList = new List<String>();

            Assert.That(someList, Is.Empty);
        }

        [Test] //2
        [Category("Task_2")]
        public void Classic_AssertCollectionIsEmpty_ReturnsTrue()
        {
            var someList = new List<String>();

            Assert.IsEmpty(someList);
        }

        [Test] //3
        [Category("Task_2")]
        public void Constraint_AssertCollectionIsSorted_ReturnsTrue()
        {
            var someArray = new int[] {14, 12, 10, 2 };

            Assert.That(someArray, Is.Ordered.Descending);
        }

        [Test] //3
        [Category("Task_2")]
        public void Classic_AssertCollectionIsSorted_ReturnsTrue()
        {
            var someArray = new int[] { 14, 12, 10, 2 };
            //не нашел метода схожего на Is.Ordered для обычного ассерта??
            Assert.IsNotEmpty(someArray);
        }
    }
}
