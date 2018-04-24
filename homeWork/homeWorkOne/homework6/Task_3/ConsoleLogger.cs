using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework6.Task_3
{
    class ConsoleLogger : ILogger
    {
        public void Log(string log)
        {
            Console.WriteLine(log);
        }
    }

    class FileLogger : ILogger
    {
        public void Log(string log)
        {
            var location = @"E:\TestDir\LogFile.txt";

            using (StreamWriter sw = new StreamWriter(location, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(log);
                //Console.WriteLine("I just wrote a file");
            }
        }
    }

    class AggregateLogger : ILogger
    {
        private ILogger[] _loggers;

        public AggregateLogger(ILogger[] Loggers)
        {
            _loggers = Loggers;
        }

        public void Log(string log)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(log);
            }
        }
    }
}
