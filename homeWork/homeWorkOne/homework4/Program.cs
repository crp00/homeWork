﻿using System;

namespace homework4
/* Homework task 1.1 & 1.2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] foodLowerCase = { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };
            string[] foodHigherCase = { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };

            Console.WriteLine("Task #1.1: \n");

            foreach (string item in foodLowerCase)
            {
                if (item.Contains("ap"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("\nTask #1.2: \n");

            foreach (string item in foodHigherCase)
            {
                string newItem = item.ToLower();
                if (newItem.Contains("ap"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}

//Homework task 2 & 3

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter int value: ");
            int i;
            int parsedInput;
            var userInput = Console.ReadLine();

            bool isParsed = Int32.TryParse(userInput, out parsedInput);
            if (isParsed)
            {
                int sum = 0;

                Console.WriteLine($"The number provided is: {parsedInput}");
                
                for (i = 1; i <= parsedInput; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                Console.WriteLine($"The sum of these numbers is: {sum}");
            }
            else
            {
                Console.WriteLine("Your value is not int..");
            }
        }
    }
}

//Homework Task #4 implementation 1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the color of banana?\n\ta. Red\n\tb. Green\n\tc. Yellow\n\td. Blue\n\te. Purple");
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (userInput == "c")
                {
                    Console.WriteLine("Correct answer");
                }
                else
                {
                    Console.WriteLine("Wrong answer, do you want to try again? Y/N");
                    string userExit = Console.ReadLine();
                    if (userExit == "Y")
                    {
                        Console.WriteLine("Please choose answer once more: ");
                    }
                    else
                    {
                        Console.WriteLine("Terminating application");
                        break;
                    }
                }
            }
            while (userInput != "c"); 
        }
    }
}

//Homework Task #4 implementation 2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the color of banana?\n\ta. Red\n\tb. Green\n\tc. Yellow\n\td. Blue\n\te. Purple");

            string userInput = " ";

            while (userInput != "c")
            {
                userInput = Console.ReadLine();
                if (userInput == "c")
                {
                    Console.WriteLine("Correct answer indeed");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong answer. Try again? Y/N");
                    string x = Console.ReadLine();
                    if (x == "Y")
                    {
                        Console.WriteLine("Ok, enter new answer");
                    }
                    else
                    {
                        Console.WriteLine("Terminating...");
                        break;
                    }
                }
            }
        }
    }
}

//Homework Task #5

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter the password: ");
            string userInput;

            do
            {
                userInput = Console.ReadLine();
                if (userInput == "root")
                {
                    Console.WriteLine("Correct Password");
                }
                else
                {
                    Console.WriteLine("Wrong password, please try again");
                }
            }
            while (userInput != "root");
        }
    }
}

*/

//Homework Task #6 Is there anything ELSE expected here? feels strange

{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            for (x = 35; x <= 87; x++)
            {
                if (x == 72)
                {
                    break;
                }
                else
                {
                    Console.Write(x + ", ");
                }
            }
        }
    }
}

//Homework Task #7

/*

{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 5;
            //i = i++;
            //Console.WriteLine(i + ++i); //11

            //int i = 2;
            //i = (++i + ++i) * (i++);
            //Console.WriteLine(i); //28

            //int i = 10;
            //i = ++i + (i--) + (i++) + (--i) - (i++);
            //Console.WriteLine(i); //32

            //int i = 12;
            //i = (i++ + (--i) - (i++)) / (--i);
            //Console.WriteLine(i); //1

            //int i = 4;
            //i = i++ + (--i) - (i--) * (i++);
            //Console.WriteLine(i); //-4
        }
    }
}

*/



