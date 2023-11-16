using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Manager : Employee
    {
        public Manager(string name, decimal salary) : base(name)
        {
            this.salary = salary;
        }

        private decimal salary;
        public override decimal CalculatePay()
        {
            return salary;
        }
    }
}
