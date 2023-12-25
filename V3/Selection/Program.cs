using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");

            Selection.Sort(array, 0);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
