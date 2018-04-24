using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Currency
    {
        #region Fields

        private int dollars;
        private int cents;

        #endregion

        #region Properties

        public int Dollars { get { return dollars; } }
        public int Cents { get { return cents; } }

        #endregion

        #region Constructors

        public Currency()
        {
            dollars = 0;
            cents = 0;
        }

        public Currency(int _dollars, int _cents)
        {
            this.dollars = _dollars;
            this.cents = _cents;
        }

        public Currency(double _dollarsAndCents)
        {
            this.dollars = (int)Math.Floor(_dollarsAndCents);
            this.cents = (int)Math.Floor((_dollarsAndCents - Math.Floor(_dollarsAndCents))*100);
        }

        #endregion

        #region Methods

        public double ToDouble()
        {
            var concatenation = Dollars.ToString() + "." + Cents.ToString();
            double result = double.Parse(concatenation, System.Globalization.CultureInfo.InvariantCulture);
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
            return string.Format("{0}.{1}", dollars, cents);
        }

        #endregion
    }
}
