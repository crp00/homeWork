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

namespace homework5 //Task #5
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

                switch (userInput)
                {
                    case "a":
                        ValidateExistingUserAndBrowseShop();
                        break;
                    case "b":
                        RegisterNewUserAndBrowseShop();
                        break;
                    case "c":
                        Console.WriteLine("Exiting application");
                        break;
                }
            }
            while (userInput != "c");
        }

        static Dictionary<string, string> userList = new Dictionary<string, string>
        {
            { "admin","12345"}
        };

        static void BrowseShop()
        {
            List<string> shoppingCart = new List<string>();

            string storeOption;

            do
            {
                Console.WriteLine("Please choose action:\na. Purchase products\nb. Print purchased list\nc. Exit store");
                storeOption = Console.ReadLine();

                switch (storeOption)
                {
                    case "a":
                        while (true)
                        {
                            Console.WriteLine("please enter product you want to buy or enter EXIT to close");
                            var selectedproduct = Console.ReadLine();
                            if (selectedproduct == "EXIT")
                                break;
                            else
                                shoppingCart.Add(selectedproduct);
                        }
                        break;
                    case "b":
                        if (shoppingCart.Count() > 0)
                            foreach (string product in shoppingCart)
                            {
                                Console.WriteLine($"You purchased {product}");
                            }
                        else
                            Console.WriteLine("Shopping cart is empty");
                        break;
                    case "c":
                            Console.WriteLine("Exiting store");
                        break;
                }
            }
            while (storeOption != "c");
             
        }

        static void RegisterNewUserAndBrowseShop()
        {
            Console.WriteLine("Please enter your login:");
            var userName = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            var userPass = Console.ReadLine();

            if (userList.ContainsKey(userName))
                Console.WriteLine("This login is already occupied");
            else
                Console.WriteLine("Registered");
                userList.Add(userName, userPass);
                BrowseShop();
        }

        static void ValidateExistingUserAndBrowseShop()
        {
            Console.WriteLine("Please enter your login:");
            var userName = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            var userPass = Console.ReadLine();

            if (userList.ContainsKey(userName) && userList[userName] == userPass)
            {
                Console.WriteLine("Authorized");
                BrowseShop();
            }
            else
                Console.WriteLine("User not found");
        }
    }
}

/* 
Task #3
 
Массивы позволяют хранить однотипные элементы. Размер фиксируеться во время инициализации и 
добавление новых елементов ограничено. Список имеет более гибкие инструменты работы с данными в виде методов
и являеться более гибкой вариацие массива а словарь при этом хранит данные в виде ключа/пары

Task 4#

queue - коллекция обьектов, которая обслуживается по принципу "первым поступил — первым обслужен".

stack - простая универсальная коллекция объектов, работает по принципу «последним поступил — первым обслужен»
*/
