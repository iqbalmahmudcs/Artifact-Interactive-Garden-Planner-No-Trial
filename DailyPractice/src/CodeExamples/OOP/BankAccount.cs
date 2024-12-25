using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Encapsulation
        * Hiding the internal state of an object and requiring all interactions to be performed through well-defined methods.
        * Use access modifiers like 
            * public, 
            * private, 
            * protected, and 
            * internal.
     */
    public class BankAccount
    {
        private double balance;    //field

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
