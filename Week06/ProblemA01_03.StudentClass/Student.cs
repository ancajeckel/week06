using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemA01.StudentClass
{
    public class Student : ICloneable, IComparable
    {
        public string FirstName { get; }

        public string LastName { get; }

        public int Age { get; set; }

        public int SSN { get; }

        public string Email { get; }

        public string Course { get; }

        public Specialties Specialty { get; }

        public Universities University { get; }

        public Faculties Faculty { get; }

        private int counter = 0;

        public Student(string firstName, string lastName, int ssn, Specialties spec, Faculties fac)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Specialty = spec;
            this.Faculty = fac;
            counter++;
        }

        public string GetName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public override bool Equals(object obj)
        {
            // If the cast is invalid, the result will be null
            Student student = obj as Student;
            // Check if we have valid not null Student object
            if (student == null)
                return false;
            // Compare the reference type member fields
            if (!Object.Equals(this.FirstName, student.FirstName))
                return false;
            if (!Object.Equals(this.LastName, student.LastName))
                return false;
            if (!Object.Equals(this.SSN, student.SSN))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            Random rand = new Random();
            hash = (hash * 7) + SSN.GetHashCode();
            hash = (hash * rand.Next(1, 1000));
            hash = (hash * counter);
            return hash;
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.LastName, this.SSN, this.Specialty, this.Faculty);
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return Student.Equals(s1, s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(Student.Equals(s1, s2));
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} (SSN: {this.SSN} Spec: {this.Specialty})");
        }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;

            if (student == null)
                return 1;

            int compareLinguistic = String.Compare(student.LastName, this.LastName);

            if (compareLinguistic == 0)
            {
                if (student.SSN > this.SSN)
                {
                    return -1;
                }
                else if (student.SSN < this.SSN)
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                return compareLinguistic;
            }
        }
    }

    public enum Specialties
    {
        Economics,
        Literature,
        Math,
        Physics
    }

    public enum Universities
    {
        UAIC,
        BucharestUniversity
    }

    public enum Faculties
    {
        Informatics,
        Economics,
        SocialSciences
    }
}
