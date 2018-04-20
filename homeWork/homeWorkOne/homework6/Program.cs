using System;

namespace homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestClass1 metalhead = new TestClass1();
            //metalhead.name = "Steve";
            //metalhead.ReturnName();

            //TestClass2 jazzman = new TestClass2();
            //jazzman.SetNeme("Franky");
            //jazzman.PrintName();  

            //TestClass3 punkguy = new TestClass3();
            //punkguy.Name = "Randy";
            //Console.WriteLine(punkguy.Name);

            //TestClass4 Musician1 = new TestClass4();
            //TestClass4 Musician2 = new TestClass4();
            //TestClass4 Musician3 = new TestClass4();

            //Musician1.Name = "John";
            //Musician2.Name = "Dallas";

            //Console.WriteLine(Musician1.Name);
            //Console.WriteLine(Musician2.Name);
            //Console.WriteLine(Musician3.Name);

            //ITestClass5 Rockstar1 = new ITestClass5();
            //Console.WriteLine($"Please welcome {Rockstar1.FirstName} mothefucking {Rockstar1.LastName}");

            //ITestClass5 Rockstar2 = new ITestClass5("John", "Whick");
            //Console.WriteLine($"Please welcome {Rockstar2.FirstName} mothefucking {Rockstar2.LastName}");

            //TestClass6 NewString1 = new TestClass6();
            //TestClass7 NewString2 = new TestClass7();
            //NewString2.InvokeMethod(NewString1);

            //TestClass8 Author1 = new TestClass8()
            //{
            //    Name = "John",
            //    Book = "Bible"
            //};

            //TestClass8 Author2 = new TestClass8()
            //{
            //    Book = "Pygmy",
            //    Name = "Chuck"
            //};

            //Console.WriteLine($"The author is {Author1.Name} and the book is called {Author1.Book}");
            //Console.WriteLine($"The author is {Author2.Name} and the book is called {Author2.Book}");

            //new TestClass9().ReturnString();

            Currency Money1 = new Currency(20, 25);

            Console.WriteLine($"There is {Money1.Dollars} dollars and {Money1.Cents} cents in my pocket");

            Currency Money2 = new Currency(30.19);

            Console.WriteLine($"Now i have {Money2.Dollars} dollars here and {Money2.Cents} cents");

            Money1.ToDouble();
        }
    }
}
