using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemA04.PersonClass
{
    class Person
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return this.Name + ", age <unspecified>";
            }
            return this.Name + ", age " + this.Age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
        }
    }
}
