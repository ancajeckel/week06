using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB09.StudentGroups
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupMember { get; set; }

        public string PrintListMarks()
        {
            string outStr = "";
            foreach (var mark in Marks)
            {
                if (outStr == "")
                {
                    outStr = mark.ToString();
                }
                else
                {
                    outStr = outStr + "," + mark.ToString();
                }
            }
            return outStr;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{FirstName} {LastName}, group: {GroupMember}, marks: {PrintListMarks()}");
        }
    }
}
