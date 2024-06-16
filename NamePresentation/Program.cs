using System.Xml.Linq;

namespace NamePresentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            Name a = new Name();
            a.FirstName = Console.ReadLine();


            a.Out();
        }
    }
}
