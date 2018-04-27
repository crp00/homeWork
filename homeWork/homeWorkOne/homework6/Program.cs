using System;
using System.Collections.Generic;

namespace homework6.Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleLogger TestLogger1 = new ConsoleLogger();

            //FileLogger TestLogger2 = new FileLogger();

            //ILogger[] loggers = new ILogger[] { TestLogger1, TestLogger2 }; 

            //AggregateLogger TestLogger3 = new AggregateLogger(loggers);

            //void LogHappyMessage(ILogger logger) //to test three implementations
            //{
            //    logger.Log("I am HAPPY!!!");
            //}

            //LogHappyMessage(TestLogger1);
            //LogHappyMessage(TestLogger2);
            //LogHappyMessage(TestLogger3);

            Citizen Kane = new Citizen("first")
            {
                Name = "Kane",
                Age = 24
            };

            LegalPerson Frank = new LegalPerson("second");

            Bank Barclays = new Bank();

            Barclays.PutMoneyToAccount(Kane, 2000);
            Console.WriteLine(Barclays.GetAccountBalance(Kane));
        }
    }
}
