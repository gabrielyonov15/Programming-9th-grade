using System;

namespace BankAccountManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            Person person = new Person();
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Как се казваш:");
                person.name = Console.ReadLine();
                Console.WriteLine("На колко години си:");
                person.age = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(person.name);
                Console.WriteLine(person.age);
            }
            acc.Id = 1;
            Console.WriteLine("Колко ще вкараш:");
            acc.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Колко ще теглиш:");
            acc.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine(acc.ToString());
            if (acc.Withdraw == acc.Deposit)
            {
                Console.WriteLine($"Не ти достигат {acc.ToString}");
            }
        }
    }
}
