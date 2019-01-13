using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemA01.StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Tudor", "A", 123445, Specialties.Economics, Faculties.Economics);
            Student stud2 = new Student("Daniel", "T", 459788, Specialties.Literature, Faculties.SocialSciences);
            Student stud3 = new Student("Tudor", "A", 123445, Specialties.Economics, Faculties.Economics);

            //compare
            CompStudents(stud1, stud2);
            CompStudents(stud1, stud3);
            CompStudents_var2(stud1, stud2);
            CompStudents_var2(stud1, stud3);

            //hashcode
            Console.WriteLine($"Student {stud1.GetName()}: {stud1.GetHashCode()}");
            Console.WriteLine($"Student {stud1.GetName()}: {stud1.GetHashCode()}");
            Console.WriteLine($"Student {stud2.GetName()}: {stud2.GetHashCode()}");
            Console.WriteLine($"Student {stud3.GetName()}: {stud3.GetHashCode()}");

            //clone
            Student sc = stud2.Clone() as Student;
            sc.PrintDetails();

            //compare
            Console.WriteLine($"Compare stud1 / stud2: {stud1.CompareTo(stud2)}");
            Console.WriteLine($"Compare stud2 / sc: {stud2.CompareTo(sc)}");

            Console.ReadKey();
        }

        public static void CompStudents(Student s1, Student s2)
        {
            Console.WriteLine((s1.Equals(s2))
                ? $"{s1.GetName()} and {s2.GetName()} are equal"
                : $"{s1.GetName()} and {s2.GetName()} are not equal");
        }

        public static void CompStudents_var2(Student s1, Student s2)
        {
            Console.WriteLine( (s1 ==s2)
                ? $"{s1.GetName()} and {s2.GetName()} are equal"
                : $"{s1.GetName()} and {s2.GetName()} are not equal");
        }
    }
}
