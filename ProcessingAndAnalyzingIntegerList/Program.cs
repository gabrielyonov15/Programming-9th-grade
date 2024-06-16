namespace ProcessingAndAnalyzingIntegerList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Output 1:");
            foreach (int num in number)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("Output 2:");
            int start = number[0];
            int length = 1;
            int bestLength = 1;
            int startLength = 1;
            for (int i = 1; i < number.Count; i++)
            {
                if (number[i] == number[i - 1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        startLength = start;
                    }
                }
                else
                {
                    start = number[i];
                    length = 1;
                }
            }
            Console.WriteLine($"{bestLength}/{startLength}");
            Console.WriteLine("Output 3:");
            foreach (int num in number)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("Output 4:");
            int min = number[0];
            foreach (int num in number)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
