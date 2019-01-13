using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB06.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 5, 14, 8, 9, 11, 17, 21, 42 };
            DisplayArray(numbers);

            Console.WriteLine("Numbers divisible by 7 and 3 (Lambda):");
            var num_lambda = Array.FindAll(numbers, x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in num_lambda)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Numbers divisible by 7 and 3 (LINQ):");
            var num_linq =
                from number in numbers
                where (number%3 == 0 && number%7 ==0)
                select number;

            foreach (var item in num_linq)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (var number in arr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
