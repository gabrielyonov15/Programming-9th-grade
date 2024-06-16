using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementSystem
{
    internal class Person
    {
        public string name;
        public int age;
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public override string ToString()
        {
            return $"Name {this.name}, age {this.age}";
        }
    }
}
