using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartArray smarty = new SmartArray(6);

            for(int i = 0; i < 8; i++)
            {
                smarty.Add(i);
            }
            foreach(int i in smarty) { Console.Write(i + " "); }
            Console.WriteLine("\n---------");

            IEnumerator enumerator = smarty.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int i = (int)enumerator.Current;
                Console.Write(i + " ");
            }
            Console.WriteLine("\n---------");

            for(int i = 0;i < 8;i++)
            {
                Console.WriteLine("Removing " + i);
                smarty.Remove(i);
                foreach (int s in smarty) { Console.Write(s + " "); }
                Console.WriteLine();
            }

        }
    }
}
