using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework18_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new [] { 1,2,3,4,5,6,7,8};
            var arr2 = new [] { "1", "hell","worse",""};
            var arr3 = new [] { 1, 6, 12, 4, 12, 33, 88 };

            var result = arr1.Where(x => x >= 5);
            var result1 = arr2.Where(x => !string.IsNullOrEmpty(x));
            var result2 = arr3.Count(x => x > 10);
            var result4 = arr2.Take(2);
            //takewhile
            //skipwhile

            Console.WriteLine(result2);

            foreach (var x in result1)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
