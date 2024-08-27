using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
   public  class User
    {
        string name;
        int accountnumber;

        public User(string name, int accountNumber)
        {
            this.name = name;
            this.accountnumber = accountNumber;
        }
        public void DisplayBalance(double balance)
        {
            Console.WriteLine("User" +name);
            Console.WriteLine("Account Number" + accountnumber);
            Console.WriteLine("Current Balance" +balance);
        }
    }
   
}
