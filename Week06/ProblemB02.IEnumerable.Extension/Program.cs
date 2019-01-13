using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB02._IEnumerable.Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> myList = from value in Enumerable.Range(2, 6)
                                      select value;
            List<int> grades = new List<int> { 78, 92, 100, 37, 81 };

            foreach (int value in myList)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Sum: {myList.Sumext()}");
            Console.WriteLine($"Product: {myList.Productext()}");
            Console.WriteLine($"Average: {myList.Averageext()}");

            Console.WriteLine($"Sum: {grades.Sumext()}");

            Console.ReadKey();
        }
    }
}
