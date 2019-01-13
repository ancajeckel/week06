using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB01._StringBuilder.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a string builder");
            sb.Append("!£$%");
            Console.WriteLine(sb);

            //use extension method
            Console.WriteLine(sb.Substring(5,19));

            Console.ReadKey();
        }
    }
}
