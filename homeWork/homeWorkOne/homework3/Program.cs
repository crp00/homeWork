using System;


namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any int value from 0 to 100: ");
            var userInput = Console.ReadLine();
            int fixedInput; //why can't use var ?
            bool checkParse = Int32.TryParse(userInput, out fixedInput);
            if (checkParse == true)
            {
                if (fixedInput >= 0 && fixedInput <= 100)
                {
                    Console.WriteLine($"Thank you, your value is {fixedInput}");

                    switch (fixedInput)
                    {
                        case 11:
                        case 22:
                        case 67:
                            Console.WriteLine("This value is special");
                            break;
                    }

                    if (fixedInput % 2 == 0)
                    {
                        Console.WriteLine("Also this value is even");
                    }
                }
                else if (fixedInput < 0)
                {
                    Console.WriteLine("Your value is less then 0");
                }
                else
                {
                    Console.WriteLine("Your value is greater then 100");
                }
            }
            else
            {
                Console.WriteLine("Your value is not int");
            }
        }
    }
}