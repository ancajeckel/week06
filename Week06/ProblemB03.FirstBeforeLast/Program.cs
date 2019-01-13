using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemA01.StudentClass;

namespace ProblemB03.FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Alex", "B.", 123, Specialties.Economics, Faculties.Economics);
            Student s2 = new Student("Marcu", "A.", 345, Specialties.Economics, Faculties.Economics);
            Student s3 = new Student("Tudor", "W.", 566, Specialties.Economics, Faculties.Economics);
            Student s4 = new Student("Paul", "P.", 102, Specialties.Economics, Faculties.Economics);

            Student[] arr = new Student[] { s1, s2, s3, s4 };
            foreach (var stud in arr)
            {
                stud.PrintDetails();
            }

            Console.WriteLine("All students whose first name is before its last name:");
            var queryQ1 =
                    from stud in arr
                    where stud.FirstName.CompareTo(stud.LastName) < 0
                    select stud;

            foreach (var stud in queryQ1)
            {
                stud.PrintDetails();
            }

            Console.ReadKey();
        }
    }
}
