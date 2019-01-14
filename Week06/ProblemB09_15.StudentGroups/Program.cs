using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB09.StudentGroups
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = fillStudentData();
            Console.WriteLine("All students:");
            PrintSelectedData(myList);

            //Problem 09
            Console.WriteLine("Select only the students that are from group number 2 (Lambda):");
            var subList01 = myList.FindAll(x => x.GroupMember == 2);
            PrintSelectedData(subList01);

            Console.WriteLine("Select only the students that are from group number 2 (LINQ):");
            var subList01_q =
               from x in myList
               where x.GroupMember == 2
               orderby x.FirstName
               select x;
            PrintSelectedData(subList01_q);

            //Problem 13
            Console.WriteLine("Select only the students that have at least one mark Excellent - 6 (Lambda):");
            var subList02 = myList.FindAll(x => x.Marks.Count(y => y >= 6) > 0);
            PrintSelectedData(subList02);

            var subList02_q =
                from x in myList
                where x.Marks.Count(y => y >= 6) > 0
                select new
                {
                    FirstName = x.FirstName,
                    Marks = x.Marks
                };
            Console.WriteLine($"{subList02_q.Count()} records in {subList02_q.ToString()}");

            //Problem 14
            Console.WriteLine("Select only the students with exactly two marks 2 (Lambda):");
            var subList03 = myList.FindAll(x => x.Marks.Count(y => y == 2) == 2);
            PrintSelectedData(subList03);

            Console.ReadKey();
        }

        public static void PrintSelectedData(IEnumerable<Student> subList)
        {
            foreach (var item in subList)
            {
                item.PrintDetails();
            }
        }

        public static List<Student> fillStudentData()
        {
            // add students
            Student s1 = new Student
            {
                FirstName = "Victor",
                LastName = "T",
                FN = 123,
                Tel = "0722-456789",
                Email = "alex@mail.com",
                Marks = new List<int> { 6, 5, 5, 4, 9 },
                GroupMember = 2
            };

            Student s2 = new Student
            {
                FirstName = "Ionut",
                LastName = "M",
                FN = 466,
                Tel = "0722-459214",
                Email = "ionut@mail.com",
                Marks = new List<int> { 3, 2, 5, 4, 2 },
                GroupMember = 1
            };

            Student s3 = new Student
            {
                FirstName = "Marin",
                LastName = "T",
                FN = 231,
                Tel = "0722-1125498",
                Email = "marin@mail.com",
                Marks = new List<int> { 6, 5, 5, 7, 6, 8 },
                GroupMember = 2
            };

            List<Student> listStud = new List<Student> { s1, s2, s3 };
            return listStud;
        }
    }
}
