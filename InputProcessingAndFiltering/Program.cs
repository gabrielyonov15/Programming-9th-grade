namespace InputProcessingAndFiltering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            string[] name = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number:");
                number[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name:");
                name[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{name[i]} {number[i]}");
            }
            for (int i = 0; i < 5; i++)
            {
                if (i > 3)
                {
                    Console.WriteLine(number[i]);
                }

            }
            for (int i = 0; i < 5; i++)
            {
                if (name[i] == "Ivan")
                {
                    Console.WriteLine($"{name[i]} {number[i]}");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}
