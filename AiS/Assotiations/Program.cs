using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assotiations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mafia m = new Mafia("ime", "posa");
            Boss bo = new Boss("boss_ime", m);

            m.SetBoss(bo);

            Console.WriteLine(m.ToString());
            Console.WriteLine(bo.ToString());
            bo.GiveOrder();
        }
    }
}
