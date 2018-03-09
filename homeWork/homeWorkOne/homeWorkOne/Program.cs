using System;

namespace homeWorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;

            Console.Write("Please enter your name here: ");
            userName = Console.ReadLine();

            Console.WriteLine("Hello {0}", userName);
        }
    }
}
