namespace FactorialCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P = 1;
            for (var a = 7; a >= 1; a--)
            {
                P = a * P;
            }
            Console.WriteLine(P);
        }
    }
}
