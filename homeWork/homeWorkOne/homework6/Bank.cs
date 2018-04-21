using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Bank
    {
        public int bankAccount;

        public void PutMoneyToAccount(string accountholder, int quantity)
        {
            bankAccount = bankAccount + quantity;
        }

        public void GetMoneyFromAccount(string accountholder, int quantity)
        {
            bankAccount = bankAccount - quantity;
        }

        public int GetAccountBalance(string accountholder)
        {
            return bankAccount;
        }
    }
}
