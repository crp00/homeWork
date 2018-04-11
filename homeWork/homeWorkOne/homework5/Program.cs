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
            var userLogin = string.Empty;
            var userPassword = string.Empty;

            do
            {
                Console.WriteLine("Please choose option to proceed:\na. LOG IN\nb. SIGN UP\nc. EXIT");
                userInput = Console.ReadLine(); 
                if (userInput == "a")
                {
                    Console.WriteLine("Please enter your login:");
                    userLogin = Console.ReadLine();
                    Console.WriteLine("Please enter your password:");
                    userPassword = Console.ReadLine();

                    if (userList.ContainsKey(userLogin) && userList[userLogin] == userPassword)
                    {
                        Console.WriteLine("Authorized");
                    }
                    else
                        Console.WriteLine("User not found");
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
        static Dictionary<string, string> userList = new Dictionary<string, string>
        {
            { "admin","12345"}
        };
        static Dictionary<string, string> itemList = new Dictionary<string, string>
        {
            { "1","Apple"},
            { "2","Lemon"},
            { "3","Grape"},
            { "4","Peach"}
        };
        static void Shop()
        {

        }
    }
}
