namespace SortingNumbersAndNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число:");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            string[] name = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Number:");
                number[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                name[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Number:{number[i]} Name:{name[i]}");
            }
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int firstSwapVar = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = firstSwapVar;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i] + " ");
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (number[j] < number[j + 1])
                    {
                        int secondSwapVar = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = secondSwapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(number[i] + " ");
            }
            for (int i = 0; i < number.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[j] < number[k])
                    {
                        k = j;
                    }
                    int thirdSwapVar = number[i];
                    number[i] = number[k];
                    number[k] = thirdSwapVar;
                }
            }
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
