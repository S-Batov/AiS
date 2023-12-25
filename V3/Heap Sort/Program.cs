using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5, 4, 8 };
            foreach (int i in arr) { Console.Write(i + " "); }
            Console.WriteLine();

            Heap.Sort(arr);
            foreach (int i in arr) { Console.Write(i + " "); }
            Console.WriteLine();
        }
    }
}
