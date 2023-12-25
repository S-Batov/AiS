using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student ("Ivo", 4.1),
                new Student ("Ana", 4.9),
                new Student ("Iva", 4.3),
                new Student ("Bob", 4.5),
                new Student ("Joe", 4.7),
                new Student ("Tom", 4.4),
                new Student ("Iko", 4.6),
            };
            foreach (Student student in students)
                Console.WriteLine(student);
            Console.WriteLine("------------");

            Quick.Partition(students,
                            0,
                            students.Length,
                            Student.CompareName);

            foreach (Student student in students)
                Console.WriteLine(student);
            Console.WriteLine("------------");

            Quick.Sort(students,
                        0,
                        students.Length,
                        Student.CompareName);
            foreach (Student student in students)
                Console.WriteLine(student);
            Console.WriteLine("------------");

            Quick.Sort(students,
                        0,
                        students.Length,
                        Student.CompareGrade);
            foreach (Student student in students)
                Console.WriteLine(student);
        }
    }
}
