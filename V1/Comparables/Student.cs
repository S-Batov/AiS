using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparables
{
    internal class Student : IComparable
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

        public int CompareTo(object obj)
        {
            Student rhs = obj as Student;

            if (rhs == null)
                throw new ArgumentNullException("student is null");

            return this.grade.CompareTo(rhs.grade);
        }

    }
}
