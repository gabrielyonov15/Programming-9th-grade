using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveBankAccountManagement
{
    internal class BankAccount
    {
        private double balance;
        public int Id { get; set; }
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }
}
