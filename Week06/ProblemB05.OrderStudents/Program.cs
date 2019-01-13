using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemA01.StudentClass;

namespace ProblemB05.OrderStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alex", "B.", 123, Specialties.Economics, Faculties.Economics);
            Student s2 = new Student("Tudor", "A.", 345, Specialties.Economics, Faculties.Economics);
            Student s3 = new Student("Tudor", "W.", 566, Specialties.Economics, Faculties.Economics);
            Student s4 = new Student("Paul", "P.", 102, Specialties.Economics, Faculties.Economics);
            s1.Age = 18;
            s2.Age = 25;
            s3.Age = 24;
            s4.Age = 30;

            Student[] arr = new Student[] { s1, s2, s3, s4 };
            foreach (var stud in arr)
            {
                stud.PrintDetails();
            }

            Console.WriteLine("Order students by first name and last name in descending order (LINQ):");
            var queryQ1 =
                    from stud in arr
                    orderby stud.FirstName descending, stud.LastName descending
                    select stud;

            foreach (var stud in queryQ1)
            {
                stud.PrintDetails();
            }

            Console.WriteLine("Order students by first name and last name in descending order (Lambda):");
            var arr_sorted = arr.OrderByDescending(x => x.FirstName).
                                    ThenByDescending(x => x.LastName);
            foreach (var stud in arr_sorted)
            {
                stud.PrintDetails();
            }

            Console.ReadKey();
        }
    }
}
