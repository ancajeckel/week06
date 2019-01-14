using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB17.LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>() { "Apple", "Bananarama", "Peach", "Orange" };
            Console.WriteLine("Fro the list: Apple, Bananarama, Peach, Orange");

            // Lambda
            Console.WriteLine("Longest string is (using Lambda):");
            var lng = myList.OrderByDescending(s => s.Length).First();
            Console.WriteLine(lng);

            // Linq
            Console.WriteLine("Longest string is (using LINQ):");
            var myQuery =
                from str in myList
                where str.Length == (myList.Max(a => a.Length))
                select str;
            foreach (var item in myQuery)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
