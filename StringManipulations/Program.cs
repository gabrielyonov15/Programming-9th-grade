namespace StringManipulations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi, Gabriel in C#";
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi," + name);
            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hi,{0} {1}", name, lastName);
            Console.WriteLine("Surname");
            string surname = Console.ReadLine();
            Console.WriteLine($"Hi, {name} {lastName} {surname}!");
            int result = string.Compare(name, lastName, true);
            Console.WriteLine(result);
            string str1 = string.Concat(name, surname);
            Console.WriteLine(str1);
            int firstIndex = str.IndexOf(",");
            Console.WriteLine(firstIndex);
            int secondIndex = str.IndexOf("b");
            Console.WriteLine(secondIndex);
            int notFound = str.IndexOf("/");
            Console.WriteLine(notFound);
            string nameFirst = str.Substring(4, 7);
            Console.WriteLine(nameFirst);
            string nameSecond = str.Substring(0, 2);
            Console.WriteLine(nameSecond);
            string relpaced = str.Replace("C#", "Java");
            Console.WriteLine(relpaced);
        }
    }
}
