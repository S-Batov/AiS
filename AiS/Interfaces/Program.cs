using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ime1", 4.1f);
            Student s2 = new Student("ime2", 3.1f);
            Student s3 = new Student("ime3", 2.1f);
            Student s4 = new Student("ime4", 1.1f);

            Console.WriteLine(s1.ToString() + "\n" + s2.ToString() + "\n" + s3.ToString() + "\n" + s4.ToString() + "\n");

            Student[] students = new Student[6];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;

            float temp = 0.0f;
            for (int i = 0; i < 4; i++)
            {
                temp += students[i].GetGrade();
            }
            temp /= 4;
            Console.WriteLine(temp.ToString());

            Array.Sort(students);
            foreach(Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
