using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Currency
    {
//fields

        private int dollars;
        private int cents;

//properties

        public int Dollars { get { return dollars; } }
        public int Cents { get { return cents; } }

//constructors

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

//metods

        public double ToDouble()
        {
            string dollars1 = Convert.ToString(Dollars);
            string cents1 = Convert.ToString(Cents);

            string concatenation = dollars1 + "." + cents1;
            double result = double.Parse(concatenation, System.Globalization.CultureInfo.InvariantCulture);
            return result;
        }
    }
}
