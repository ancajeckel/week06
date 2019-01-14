using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB09.StudentGroups
{
    public class Group
    {
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GroupNumber} {DepartmentName}");
        }
    }
}
