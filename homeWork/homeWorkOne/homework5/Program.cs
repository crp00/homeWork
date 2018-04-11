using System;
using System.Collections.Generic;
using System.Linq;

/*
namespace homework5
{
    class Program
    {
        static int[] someArray = { 4, 33, 32, 55, 34, 77, 13 };

        static void ReturnAll()
        {
            foreach (int x in someArray)
            {
                Console.WriteLine(x);
            }
        }
        static void ReturnLast()
        {
            Console.WriteLine(someArray.Last());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            ReturnAll();
            Console.WriteLine("Task 2:");
            ReturnLast();
        }
    }
}
*/

namespace homework5
{
    class Program
    {

        static void Main(string[] args)
        {
            var userInput = string.Empty;

            do
            {
                Console.WriteLine("Please choose option to proceed:\na. LOG IN\nb. SIGN UP\nc. EXIT");
                userInput = Console.ReadLine();
                if (userInput == "a")
                {
                    Console.WriteLine("LOG IN GO GO");
                }
                else if (userInput == "b")
                {
                    Console.WriteLine("Sign Up GO GO");
                }
                else if (userInput == "c")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            }
            while (true);
        }
    }
}
