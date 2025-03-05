using CapGExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_1_BankAccount

    {
        private decimal balance;
        public Prgm_1_BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance must be greater than or equal to zero.");
            }
            balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.Write($"Deposited: {amount:C}>New balance: { balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }

        }
        public void Withdraw(decimal amount)
        {
            if ( amount >0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}>Remaining balance: {balance:C}");
            }
            else if (amount <=0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        public decimal GetBalance() 
        {
            return balance;
        }
    }
}

