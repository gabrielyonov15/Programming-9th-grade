namespace SummationOfASeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каква оценка искаш?");
            int x = int.Parse(Console.ReadLine());
            int P = 0;
            int a = 6;
            do
            {
                P = a * x + P;
                a = a + 1;
            }
            while (a <= 6);
            {
                Console.WriteLine("P=" + P);
            }
        }
    }
}
