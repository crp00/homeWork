using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Bank
    {
        Dictionary<string,int> customers = new Dictionary<string, int>();

        public void PutMoneyToAccount(string accountholder, int quantity)
        {
            if (customers.ContainsKey(accountholder))
                customers[accountholder] += quantity;
            else
                customers.Add(accountholder, quantity);
        }

        public void GetMoneyFromAccount(string accountholder, int quantity)
        {
            if (customers.ContainsKey(accountholder))
                customers[accountholder] -= quantity;
            else
                Console.WriteLine("customer not found");
        }

        public int GetAccountBalance(string accountholder)
        {
            return customers[accountholder];
        }
    }
}
