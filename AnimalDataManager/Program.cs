namespace AnimalDataManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken A = new Chicken();
            PolChicken B = new PolChicken();
            List<string> animal = new List<string>();
            Console.WriteLine("N=");
            int n = int.Parse(Console.ReadLine());
            int[] age = new int[n];
            double[] date = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Color:");
                A.Color = Console.ReadLine();
                Console.WriteLine("Date:");
                date[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Animal:");
                animal.Add(Console.ReadLine());
                Console.WriteLine("Age:");
                age[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Gender:");
                B.Gender = Console.ReadLine();
                Console.WriteLine($"{A.Color} - {date[i]} - {animal[i]}");
                Console.WriteLine($"{age[i]} - {B.Gender}");
                Console.WriteLine($"Color:{A.Color}  Date:{date[i]} Animal:{animal[i]}");
                Console.WriteLine($"Age:{age[i]} Gender:{B.Gender}");
            }
            for (int i = 0; i < n; i++)
            {
                if (A.Color == "red")
                {
                    Console.WriteLine($"{animal[i]}");
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (B.Gender == "male")
                {
                    Console.WriteLine(B.Gender);
                }
            }
            for (int i = 0; i < date.Length - 1; i++)
            {
                for (int j = 0; j < date.Length - 1; j++)
                {
                    if (date[j] > date[j + 1])
                    {
                        double swapVar = date[j];
                        date[j] = date[j + 1];
                        date[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(date[i]);
            }
            for (int i = 0; i < age.Length - 1; i++)
            {
                for (int j = 0; j < age.Length - 1; j++)
                {
                    if (age[j] > age[j + 1])
                    {
                        int swapVar = age[j];
                        age[j] = age[j + 1];
                        age[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(age[i]);
            }
        }
    }
}
