using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataManagement
{
    internal class Person
    {
        public string name;
        public int age;
        public string city;

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
        public String City
        {
            get { return this.city; }
            set { this.city = value; }
        }
    }
}
