namespace ConcatenationOfTwoStringsWithSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = Console.ReadLine();
            Console.WriteLine(String.Concat(str, " ", str1));
        }
    }
}
