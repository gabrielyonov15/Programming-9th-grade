namespace LengthOfStringsInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] text = new string[n];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i].Length);
            }
        }
    }
}
