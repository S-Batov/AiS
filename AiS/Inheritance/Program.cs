using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager ceo = new Manager("ime", 10000);
            Worker w1 = new Worker(10, 10, "ime1");
            Worker w2 = new Worker(20, 10, "ime2");
            Worker w3 = new Worker(30, 10, "ime3");

            List<Employee> employees = new List<Employee>() { ceo, w1, w2, w3 };

            decimal total = 0.0m;

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            foreach(Employee emp in employees)
            {
                total += emp.CalculatePay();
            }
            Console.WriteLine("Payroll: " + total.ToString());
        }
    }
}
