using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Student : IComparable
    {
        public Student(string name, float grade)
        {
            this.name = name;
            this.grade = grade;
        }

        private string name;
        private float grade;

        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
        public float GetGrade()
        {
            return this.grade;
        }

        public int CompareTo(object obj)
        {
            Student temp = (Student)obj;
            if (this.grade < temp.grade)
            {
                return -1;
            }
            else if (this.grade > temp.grade)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return this.name + ": " + (float)this.grade;
        }
    }
}
