namespace DisplayingNumbersEndingWith5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 1000; i++)
            {
                if (i % 10 == 5)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
