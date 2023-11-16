using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Employee
    {
        public Employee(string name)
        {
            this.name = name;
        }

        private string name;

        public virtual decimal CalculatePay()
        {
            return 0.0m;
        }
        public override string ToString()
        {
            return name + ": " + this.CalculatePay();
        }
    }
}
