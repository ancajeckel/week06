using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemB09.StudentGroups;


namespace ProblemB16.Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 16
            //take over students from the other project
            var studList = ProblemB09.StudentGroups.Program.fillStudentData();
            Console.WriteLine("All students:");
            ProblemB09.StudentGroups.Program.PrintSelectedData(studList);

            //fill in groups
            var groupList = fillGroupsData();
            Console.WriteLine("All groups:");
            PrintAllGroups(groupList);

            //query with join
            Console.WriteLine("Select all students from Mathematics department:");
            var myQuery =
                from s in studList
                join g in groupList on s.GroupMember equals g.GroupNumber
                where g.DepartmentName == "Mathematics"
                select s;
            ProblemB09.StudentGroups.Program.PrintSelectedData(myQuery);

            //Problem 18
            Console.WriteLine("Group all students by GroupNumber:");
            var groupQuery =
                from stud in studList
                join grp in groupList on stud.GroupMember equals grp.GroupNumber
                group stud by stud.GroupMember into grOut
                orderby grOut.Key
                select grOut;
            foreach (var grp in groupQuery)
            {
                Console.WriteLine($"---------- Group: {grp.Key}  ------------");
                foreach (var stud in grp)
                {
                    Console.WriteLine($"\t Student: {stud.FirstName} {stud.LastName}");
                }
            }

            Console.ReadKey();
        }

        public static List<Group> fillGroupsData()
        {
            Group g1 = new Group
            {
                GroupNumber = 1,
                DepartmentName = "Economics"
            };

            Group g2 = new Group
            {
                GroupNumber = 2,
                DepartmentName = "Mathematics"
            };

            return new List<Group> { g1, g2 };
        }

        public static void PrintAllGroups(List<Group> aGroupList)
        {
            foreach (var item in aGroupList)
            {
                item.PrintDetails();
            }
        }
    }
}
