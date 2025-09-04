using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        public float Balance { get; private set; }

        public BankAccount(int accountNumber, string accountHolderName = "", float balance = 0)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            if (balance < 0) throw new ArgumentException("Account number should be a positive number");
            Balance = balance;
        }

        public bool Deposite(float amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("the deposite amount should be positive");
                return false;
            }

            this.Balance += amount;
            return true;
        }
        public bool Withdraw(float amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                return true;
            }
            else
            {
                throw new ArgumentException("you have no enough Balance");
                return false;
            }
        }
    }
}
