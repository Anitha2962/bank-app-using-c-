using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
    public class Transaction
    {
        double balance;
        public Transaction()
        {
            balance = 5000;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("amount deposited:" + amount);
            }
            else
            {
                Console.WriteLine("amount not deposited");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >0 && amount <=balance)
            {
                balance -= amount;
                Console.WriteLine("amount withdraw:" + amount);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }

        public double getbalance()
        {
            return balance;
        }
    }

}
