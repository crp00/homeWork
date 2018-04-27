using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class Bank
    {
        Dictionary<IHasId,int> customers = new Dictionary<IHasId, int>();

        //public void PutMoneyToAccount(string accountholder, int quantity)
        //{
        //    if (customers.ContainsKey(accountholder))
        //        customers[accountholder] += quantity;
        //    else
        //        customers.Add(accountholder, quantity);
        //}

        public void PutMoneyToAccount(IHasId accountholder, int quantity)
        {
            if (customers.ContainsKey(accountholder))
                customers[accountholder] += quantity;
            else
                customers.Add(accountholder, quantity);
        }

        public void GetMoneyFromAccount(IHasId accountholder, int quantity)
        {
            if (customers.ContainsKey(accountholder))
                customers[accountholder] -= quantity;
            else
                Console.WriteLine("customer not found");
        }

        public int GetAccountBalance(IHasId accountholder)
        {
            return customers[accountholder];
        }
    }
}
