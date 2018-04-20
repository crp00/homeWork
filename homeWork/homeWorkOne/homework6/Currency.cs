using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Currency
    {
        private int dollars;
        private int cents;

        public int Dollars { get { return dollars; } }
        public int Cents { get { return cents; } }

        public Currency()
        {
            dollars = 0;
            cents = 0;
        }

        public Currency(int x, int y)
        {
            this.dollars = x;
            this.cents = y;
        }

        public Currency(double a)
        {
            
            this.dollars = (int)Math.Floor(a);
            this.cents = (int)Math.Floor((a - Math.Floor(a))*100);
        }

        public void ToDouble()
        {
            Console.WriteLine(Dollars);
            Console.WriteLine(Cents);
        }

        public void Add()
        {

        }

        public void Multiply(int value)
        {

        }

        //public override string ToString()
        //{
        //    return string.Format("{0}.{1}",dollars,cents);
        //}

        //public double ToDouble(string str)
        //{
        //    double n;
        //    var d = double.TryParse(str, out n);
        //    return n;
        //}
    }
}
