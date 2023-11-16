using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assotiations
{
    internal class Boss
    {
        public Boss(string name, Mafia mafia)
        {
            this.name = name;
            this.mafia = mafia;
        }

        string name;
        Mafia mafia;

        public void GiveOrder()
        {
            mafia.PerformSecretActivity();
        }
        public override string ToString()
        {
            return ("Boss: " + this.name + " " + this.mafia.ToString());
        }
    }
}
