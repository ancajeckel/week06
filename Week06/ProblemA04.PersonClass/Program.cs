using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemA04.PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "John", Age = 25 };
            p1.PrintDetails();
            Console.WriteLine(p1.ToString());

            Person p2 = new Person { Name = "Dummy", Age = null };
            p2.PrintDetails();
            Console.WriteLine(p2.ToString());

            Console.ReadKey();
        }
    }
}
