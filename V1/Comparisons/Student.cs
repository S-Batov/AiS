using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    internal class Student
    {
        private string name;
        private double grade;

        public Student(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return "Name: " + name + ", Grade: " + grade;
        }

        public static bool CompareName(object _s1, object _s2)
        {
            Student s1 = (Student) _s1;
            Student s2 = (Student) _s2;

            if(s1.name.CompareTo(s2.name) < 0)
                return true;

            return false;
        }

        public static bool CompareGrade(object _s1, object _s2)
        {
            Student s1 = (Student)_s1;
            Student s2 = (Student)_s2;

            if (s1.grade > s2.grade) return true;
            return false;
        }
    }
}
