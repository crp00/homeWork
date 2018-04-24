using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Bank
    {
        public int bankAccount = 0;

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
            Console.WriteLine(bankAccount);
            return bankAccount;
        }
    }
}
