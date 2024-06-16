using System;

namespace PersonalDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Колко данни ще въвеждаш:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Как се казваш:");
                person.name = Console.ReadLine();
                Console.WriteLine("На колко години си:");
                person.age = int.Parse(Console.ReadLine());
                Console.WriteLine("Въведи град:");
                person.city = Console.ReadLine();
                Console.WriteLine($"{person.name} {person.age} {person.city}");
            }
            for (int i = 0; i < n; i++)
            {
                if (person.city == "Sopot")
                {
                    Console.WriteLine($"{person.name} {person.age} {person.city}");
                }
                else
                {
                    Console.WriteLine("Не е от Сопот.");
                }
            }
        }
    }
}
