namespace FinancialInformationRecorder
{
    internal class Fields
    {
        public static string Name { get; set; }
        public static string Date { get; set; }
        public static double moneyIn { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Колко души ще въвеждаш");
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            string[] date = new string[n];
            double[] moneyIn = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Въведи име");
                Fields.Name = Console.ReadLine();
                name[i] = Fields.Name;
                Console.WriteLine("Въведи дата");
                Fields.Date = Console.ReadLine();
                date[i] = Fields.Date;
                Console.WriteLine("Въведи вкарани пари");
                Fields.moneyIn = double.Parse(Console.ReadLine());
                moneyIn[i] = Fields.moneyIn;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Name:{name[i]} Date:{date[i]} MoneyIn:{moneyIn[i]}");
            }
        }
    }
}
