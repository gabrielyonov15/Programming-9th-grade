using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDataManager
{
    internal class PolChicken
    {
        private string gender;
        private int age;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void output()
        {
            Console.WriteLine($"{Age} - {Gender}");
            Console.WriteLine($"Age:{Age} Gender:{Gender}");
        }
    }
    internal class Chicken
    {
        private string color;
        private double date;
        List<string> animal = new List<string>();
        public List<string> Animal
        {
            get { return animal; }
            set { animal = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Date
        {
            get { return date; }
            set { date = value; }
        }
        public void Output()
        {
            Console.WriteLine($"{Color} - {Date} - {animal}");
            Console.WriteLine($"Color:{Color}  Date:{Date} Animal:{animal}");
        }
    }
}
