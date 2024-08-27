using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transactions.Transaction t = new Transactions.Transaction();
            t.Deposit(1500);
            Console.WriteLine("final balance:"+ t.getbalance());
            t.Withdraw(2000);
            double balance = t.getbalance();
            Console.WriteLine("Final Balance" +balance);
            Console.ReadLine();
        }
    }
}
