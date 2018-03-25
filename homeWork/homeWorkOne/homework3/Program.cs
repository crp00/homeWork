using System;


namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter any int value from 0 to 100: ");
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput >= 0 && userInput <= 100)
                {
                    Console.WriteLine($"Thank you, your value is {userInput}");

                    switch (userInput)
                    {
                        case 11:
                        case 22:
                        case 67:
                            Console.WriteLine("This value is special");
                            break;
                    }

                    if (userInput % 2 == 0)
                    {
                        Console.WriteLine("Also this value is even");
                    }
                }
                else if (userInput < 0)
                {
                    Console.WriteLine("Your value is less then 0");
                }
                else
                {
                    Console.WriteLine("Your value is greater then 100");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You need to enter int value specifically");
            }
        }
    }
}