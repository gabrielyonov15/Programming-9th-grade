using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupInformationDisplay
{
    internal class Group
    {
        private string name;
        private double grade;
        private string adress;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public String Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Аз съм {name} и съм от {adress} и имам {grade}.");
            Console.WriteLine("Аз съм {0} и съм от {1} и имам {2}.", name, adress, grade);
            Console.WriteLine("Аз съм " + name + "и съм от " + adress + "и имам " + grade + ".");
        }
    }
}
