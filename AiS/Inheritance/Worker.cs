using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Worker : Employee
    {
        public Worker(decimal wage, int hours, string name) : base(name)
        {
            this.wage = wage;
            this.hours = hours;
        }

        private decimal wage;
        private int hours;

        public override decimal CalculatePay()
        {
            return wage*hours;
        }
    }
}
