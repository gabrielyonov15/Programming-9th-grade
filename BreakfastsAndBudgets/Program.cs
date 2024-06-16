namespace BreakfastsAndBudgets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] money = new double[2];
            string[] typeOfBreakfast = new string[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter money:");
                money[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter type of breakfast:");
                typeOfBreakfast[i] = Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{typeOfBreakfast[i]} / {money[i]}");
            }
        }
    }
}
