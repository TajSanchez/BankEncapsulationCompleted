using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{

  
     public class BankAccount
    {
        private double balance=0;

        public BankAccount()
        {

        }

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
            Console.WriteLine($"Simulating a deposit amount of {depositAmount, 0:c} to your account.");
        }

        public double GetBalance()
        {
            return balance;
        }
       
    }

    
    
    
}
