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
        *public: Accessible from anywhere.
            *Example: Any code in the project or outside can access it.
        *private: Accessible only within the same class.
            *Example: Used for internal data protection, hiding it from external interference.
        *protected: Accessible within the same class and derived classes.
            *Example: Often used in inheritance scenarios.
        *internal: Accessible within the same assembly (project).
            *Example: Useful for project-level access control.
        *protected internal: Accessible within the same assembly or in derived classes.
        *private protected: Accessible within the same class or derived classes in the same assembly.
     */
    public class BankAccount
    {
        private double balance;    //Private Field

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            }
            else
                Console.WriteLine("Invalid deposit amount.");
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
