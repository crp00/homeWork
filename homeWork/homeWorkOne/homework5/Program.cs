using System;
using System.Collections.Generic;
using System.Linq;

namespace homework5
{
    class Program
    {
        static int[] someArray = { 4, 33, 32, 55, 34, 77 };

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
