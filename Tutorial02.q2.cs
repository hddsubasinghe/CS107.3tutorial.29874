using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02q2
{
    internal class BankAccount
    {
       
        
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit of ${amount} successful.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive amount.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
           
            BankAccount myAccount = new BankAccount();

            
            myAccount.AccountNumber = "123456789";
            myAccount.Balance = 1000.0m; 

            
            Console.WriteLine($"Account Information:");
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${myAccount.Balance}");

            
            Console.Write("Enter the deposit amount: $");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            myAccount.Deposit(depositAmount);

            
            Console.WriteLine($"Updated Balance: ${myAccount.Balance}");

            
            Console.ReadLine();
        }
    }
}
    

