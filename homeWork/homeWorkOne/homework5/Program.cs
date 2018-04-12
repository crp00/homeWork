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
                    ValidateExistingUser();
                }
                else if (userInput == "b")
                {
                    AddNewUser();
                }
                else if (userInput == "c")
                {
                    Console.WriteLine("Exiting application");
                    break;
                }
            }
            while (true);
        }

        static Dictionary<string, string> userList = new Dictionary<string, string>
        {
            { "admin","12345"}
        };

        //static List<string> shoppingCart = new List<string>();

        static void Shop()
        {
            List<string> shoppingCart = new List<string>();

            while (true)
            {
                Console.WriteLine("Please choose next action:\na. Purchase products\nb. Print purchased list\nc. Exit store");
                var storeOption = Console.ReadLine();
                if (storeOption == "a")
                {
                    while (true)
                    {
                        Console.WriteLine("please enter product you want to buy or enter EXIT to close");
                        var selectedproduct = Console.ReadLine();
                        if (selectedproduct == "EXIT")
                        {
                            break;
                        }
                        else
                        {
                            shoppingCart.Add(selectedproduct);
                        }
                    }
                }
                else if (storeOption == "b")
                {
                    if (shoppingCart.Count() > 0)
                    {
                        foreach (string product in shoppingCart)
                        {
                            Console.WriteLine($"You purchased {product}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shopping cart is empty");
                    }
                }
                else if (storeOption == "c")
                {
                    Console.WriteLine("Exiting store");
                    break;
                }
            }
        }

        static void AddNewUser()
        {
            Console.WriteLine("Please enter your login:");
            var userName = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            var userPass = Console.ReadLine();

            if (userList.ContainsKey(userName))
            {
                Console.WriteLine("This login is already occupied");
            }
            else
            {
                Console.WriteLine("Registered");
                userList.Add(userName, userPass);
                Shop();
            }
        }

        static void ValidateExistingUser()
        {
            Console.WriteLine("Please enter your login:");
            var userName = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            var userPass = Console.ReadLine();

            if (userList.ContainsKey(userName) && userList[userName] == userPass)
            {
                Console.WriteLine("Authorized");
                Shop();
            }
            else
                Console.WriteLine("User not found");
        }

    }
}
