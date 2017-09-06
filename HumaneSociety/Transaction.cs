using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Transaction
    {
        public double startingMoney = 350.00;
        public Transaction()
        {


        }
        public bool AddTotal(double total)
        {
            if (total < startingMoney)
            {
                startingMoney += total;
                Console.WriteLine(startingMoney);
                return true;
            }
            return false;
        }
    }
}

