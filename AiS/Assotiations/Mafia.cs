using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assotiations
{
    internal class Mafia
    {
        public Mafia(string name, string business)
        {
            this.name = name;
            this.business = business;
            this.boss = null;
        }

        string name;
        string business;
        Boss boss;

        public void SetBoss(Boss boss)
        {
            this.boss = boss;
        }
        public void PerformSecretActivity()
        {
            Console.WriteLine("Bussiness done.");
        }
        public override string ToString()
        {
            return ("Mafia: " +  this.name + ", " + this.business);
        }
    }
}
