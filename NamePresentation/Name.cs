using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePresentation
{
    internal class Name
    {
        private string firstName;
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public void Out()
        {
            Console.WriteLine($"Аз съм {firstName} и съм много добър.");
        }
    }
}
