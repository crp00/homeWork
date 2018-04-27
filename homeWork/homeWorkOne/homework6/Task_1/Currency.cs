using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Currency
    {
        #region Properties

        public int Dollars { get; }
        public int Cents { get; }

        #endregion

        #region Constructors

        public Currency()
        {
            Dollars = 0;
            Cents = 0;
        }

        public Currency(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        //public Currency(double _dollarsAndCents)
        //{
        //    Dollars = (int)Math.Floor(_dollarsAndCents);
        //    Cents = (int)Math.Floor((_dollarsAndCents - Math.Floor(_dollarsAndCents))*100);
        //}

        public Currency(double dollarsAndCents)
        {
            Dollars = (int)dollarsAndCents;
            Cents = ((int)(dollarsAndCents * 100)) % 100;
        }

        #endregion

        #region Methods

        public double ToDouble()
        {
            double result = Dollars + (((double)Cents) / 100);
            return result;
        }

        public Currency Add(Currency currency)
        {
            return new Currency(this.ToDouble() + currency.ToDouble());
        }

        public Currency Multiply(int multiplier)
        {
            return new Currency(this.ToDouble() * multiplier);
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", Dollars, Cents);
        }

        #endregion
    }
}
