using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInformationPresenter
{
    internal class Dog
    {
        static int dogCount;

        private string name;
        private int age;
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            dogCount += 1;
        }
        public void firstBark()
        {
            Console.WriteLine("ball-ball");
        }
        public void secondBark()
        {
            Console.WriteLine("meow-meow");
        }
        public void firstPrintInfo()
        {
            Console.WriteLine("Dog's name:" + this.name + "; age:" + this.age + "; Обажда се със: ");
            this.firstBark();
        }
        public void secondPrintInfo()

        {
            Console.WriteLine("Cat's name:" + this.name + "; age:" + this.age + "; Обажда се със: ");
            this.secondBark();
        }
    }
}
