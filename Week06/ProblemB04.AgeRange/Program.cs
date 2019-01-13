using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemA01.StudentClass;

namespace ProblemB034.AgeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alex", "B.", 123, Specialties.Economics, Faculties.Economics);
            Student s2 = new Student("Marcu", "A.", 345, Specialties.Economics, Faculties.Economics);
            Student s3 = new Student("Tudor", "W.", 566, Specialties.Economics, Faculties.Economics);
            Student s4 = new Student("Paul", "P.", 102, Specialties.Economics, Faculties.Economics);
            s1.Age = 18;
            s2.Age = 25;
            s3.Age = 24;
            s4.Age = 30;

            Student[] arr = new Student[] { s1, s2, s3, s4 };
            foreach (var stud in arr)
            {
                Console.WriteLine($"{stud.FirstName} age {stud.Age}");
            }

            Console.WriteLine("All students with age between 18 and 24:");
            var queryQ1 =
                    from stud in arr
                    where (stud.Age >= 18 && stud.Age <= 24)
                    select stud;

            foreach (var stud in queryQ1)
            {
                Console.WriteLine($"{stud.FirstName} age {stud.Age}");
            }

            Console.ReadKey();
        }
    }
}
