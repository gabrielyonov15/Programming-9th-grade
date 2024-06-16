namespace SubjectsAndHoursManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] subject = new string[3];
            double[] hour = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter subject:");
                subject[i] = Console.ReadLine();
                Console.WriteLine("Enter time:");
                hour[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Output 1");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(subject[i]);
                Console.WriteLine(hour[i]);
            }
            Console.WriteLine("Output 2");
            for (int i = 0; i < 3; i++)
            {
                if (hour[i] >= 4)
                {
                    Console.WriteLine(hour[i]);
                }
            }
            Console.WriteLine("Output 3");
            Array.Sort(hour);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(hour[i]);
            }
            Console.WriteLine("Output 4");
            Array.Sort(subject);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(subject[i]);
            }
            Console.WriteLine("Output 5");
            Array.Reverse(subject);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(subject[i]);
            }
            Console.WriteLine("Output 6");
            string newSubject = "Maths";
            for (int i = 0; i < 3; i++)
            {
                if (subject[i] == newSubject)
                {
                    Console.WriteLine(subject[i]);
                    Console.WriteLine(hour[i]);
                }
            }
            Console.WriteLine("Output 7");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(newSubject[1]);
                Console.WriteLine(hour[1]);
            }
        }
    }
}
