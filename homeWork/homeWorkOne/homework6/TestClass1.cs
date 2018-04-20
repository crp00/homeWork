using System;

namespace homework6
{
    class TestClass1
    {
        public string name;
        private string status = " IS DEAD";
        public void ReturnName()
        {
            Console.WriteLine(name + status);
        }
    }
    class TestClass2
    {
        private string personName;

        public void SetNeme(string name)
        {
            personName = name;
        }
        public void PrintName()
        {
            Console.WriteLine(personName);
        }
    }
    class TestClass3
    {
        private string name;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
    class TestClass4
    {
        private string name = null;

        public string Name
        {
            set
            {
                if (value == "John")
                    name = value.ToUpper();
                else
                    name = value;
            }
            get
            {
                if (name == null)
                    return "value not set";
                else
                    return name;
            }
        }
    }
    class ITestClass5
    {
        private string firstname, lastname;

        public string FirstName
        {
            get { return firstname; }
        }
        public string LastName
        {
            get { return lastname; }
        }
        public ITestClass5()
        {
            Console.WriteLine("Default");
        }
        public ITestClass5(string x, string y)
        {
            Console.WriteLine("User");
            this.firstname = x;
            this.lastname = y;
        }
    }
    class TestClass6
    {
        public void ReturnString()
        {
            Console.WriteLine("What the hell is goin on?!");
        }
    }
    class TestClass7
    {
        public void InvokeMethod(TestClass6 my)
        {
            my.ReturnString();
        }
    }
    class TestClass8
    {
        public string Name { get; set; }
        public string Book { get; set; }
    }
    class TestClass9
    {
        public void ReturnString()
        {
            Console.WriteLine("This is a string here..");
        }
    }
}
