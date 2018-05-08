using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using homework8;
using System.Text.RegularExpressions;

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

            Assert.That(result, Is.EqualTo(expected), $"Actual result is {result} but expected result is {expected}");
        }

        [Test] //1
        [Category("Task_2")]
        public void Classic_AssertSumOfXandY_ReturnsTrue()
        {
            var X = 12;
            var Y = 10;
            var expected = 22;

            var result = X + Y;

            Assert.AreEqual(result, expected, $"Actual result is {result} but expected result is {expected}");
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
            var someArray = new int[] { 14, 12, 10, 2 };

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

        [Test] //4
        [Category("Task_2")]
        public void Constraint_AssertXisGreaterThanY_ReturnsTrue()
        {
            var X = 13;
            var Y = 9;

            Assert.That(X, Is.GreaterThan(Y));
        }

        [Test] //4
        [Category("Task_2")]
        public void Classic_AssertXisGreaterThanY_ReturnsTrue()
        {
            var X = 13;
            var Y = 9;

            Assert.Greater(X, Y);
        }

        [Test] //5
        [Category("Task_2")]
        public void Constraint_AssertYisTheSameAsX_ReturnsTrue()
        {
            var X = "Something";
            var Y = X;

            Assert.That(Y, Is.SameAs(X));
        }

        [Test] //5
        [Category("Task_2")]
        public void Classic_AssertYisTheSameAsX_ReturnsTrue()
        {
            var X = "Something";
            var Y = X;

            Assert.AreSame(Y, X);
        }

        [Test] //6
        [Category("Task_2")]
        public void Constraint_AssertYisNotTheSameAsX_ReturnsTrue()
        {
            var X = "Something";
            var Y = "Anything";

            Assert.That(Y, Is.Not.SameAs(X));
        }

        [Test] //6
        [Category("Task_2")]
        public void Classic_AssertYisNotTheSameAsX_ReturnsTrue()
        {
            var X = "Something";
            var Y = "Anything";

            Assert.AreNotSame(Y, X);
        }

        [Test] //7
        [Category("Task_2")]
        public void Constraint_AssertObjectIsNotNull_ReturnsTrue()
        {
            var person = new Manager("fred", "sykes", 30);

            Assert.That(person, Is.Not.Null);
        }

        [Test] //7
        [Category("Task_2")]
        public void Classic_AssertObjectIsNotNull_ReturnsTrue()
        {
            var person = new Manager("fred", "sykes", 30);

            Assert.NotNull(person);
        }

        [Test] //8
        [Category("Task_2")]
        public void Constraint_AssertVarTypeOfString_ReturnsTrue()
        {
            var person = "Jackie Chan";

            Assert.That(person, Is.TypeOf(typeof(string)));
        }

        [Test] //8
        [Category("Task_2")]
        public void Classic_AssertVarTypeOfString_ReturnsTrue()
        {
            var person = "Jackie Chan";

            Assert.IsInstanceOf(typeof(string), person);
        }

        [Test] //9
        [Category("Task_2")]
        public void Constraint_AssertVarNotTypeOfString_ReturnsTrue()
        {
            var dollars = 100;

            Assert.That(dollars, Is.Not.TypeOf(typeof(string)));
        }

        [Test] //9
        [Category("Task_2")]
        public void Classic_AssertVarNotTypeOfString_ReturnsTrue()
        {
            var dollars = 100;

            Assert.IsNotInstanceOf(typeof(string), dollars);
        }

        [Test] //10
        [Category("Task_2")]
        public void Constraint_AssertStringContainsWord_ReturnsTrue()
        {
            var phrase = "Beauty in the eyes of a beer-holder!";

            Assert.That(phrase, Does.Contain("beer"));
        }

        [Test] //10
        [Category("Task_2")]
        public void Classic_AssertStringContainsWord_ReturnsTrue()
        {
            var phrase = "Beauty in the eyes of a beer-holder!";

            Assert.IsTrue(phrase.Contains("beer"));
        }

        [Test] //11
        [Category("Task_2")]
        public void Constraint_AssertStringStartsWithWord_ReturnsTrue()
        {
            var phrase = "Beauty in the eyes of a beer-holder!";

            Assert.That(phrase, Does.StartWith("Beauty"));
        }

        [Test] //11
        [Category("Task_2")]
        public void Classic_AssertStringStartsWithWord_ReturnsTrue()
        {
            var phrase = "Beauty in the eyes of a beer-holder!";

            Assert.IsTrue(phrase.StartsWith("Beauty"));
        }

        [Test] //12
        [Category("Task_2")]
        public void Constraint_AssertCollectionIsEquivalentToAnotherCollection_ReturnsTrue()
        {
            int[] array1 = new int[] { 3, 4, 5 };
            int[] array2 = new int[] { 5, 3, 4 };

            Assert.That(array2, Is.EquivalentTo(array1));
        }

        [Test] //12
        [Category("Task_2")]
        public void Classic_AssertCollectionIsEquivalentToAnotherCollection_ReturnsTrue()
        {
            int[] array1 = new int[] { 3, 4, 5 };
            int[] array2 = new int[] { 5, 3, 4 };

            //Не нашел аналога для классического метода? 
        }

        [Test] //13
        [Category("Task_2")]
        public void Constraint_AssertObjectHasSpecificProperty_ReturnsTrue()
        {
            var employee = new Manager("John", "Wick", 42);

            Assert.That(employee,Has.Property("FirstName").EqualTo("John"));
        }

        [Test] //13
        [Category("Task_2")]
        public void Classic_AssertObjectHasSpecificProperty_ReturnsTrue()
        {
            var employee = new Manager("John", "Wick", 42);

            Assert.IsTrue(employee.FirstName.Equals("John"));
        }

        [Test] //14
        [Category("Task_2")]
        public void Constraint_AssertXisLessThanAndBiggerThanY_ReturnsTrue()
        {
            var x = 20;
            var y1 = 10;
            var y2 = 30;

            Assert.That(x, Is.GreaterThan(y1) & Is.LessThan(y2));
        }

        [Test] //14
        [Category("Task_2")]
        public void Classic_AssertXisLessThanAndBiggerThanY_ReturnsTrue()
        {
            var x = 20;
            var y1 = 10;
            var y2 = 30;

            Assert.Greater(x, y1);
            Assert.Less(x, y2);
        }

        [Test] //15
        [Category("Task_2")]
        public void Constraint_AssertStringMatchesKeyWords_ReturnsTrue()
        {
            var someString = "Do something somewhere for some other purpose";

            Assert.That(someString,Does.Match("something.*for.*purpose"));
        }

        [Test] //15
        [Category("Task_2")]
        public void Classic_AssertStringMatchesKeyWords_ReturnsTrue()
        {
            var someString = "Do something somewhere for some other purpose";


            //Assert.IsTrue(someString.Contains("something.*for.*purpose"));
            Assert.IsTrue(Regex.IsMatch(someString, "something.*for.*purpose"));
        }
    }
}
