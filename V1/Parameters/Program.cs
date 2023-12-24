using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 1; int b = 2;
            Console.WriteLine("a: " + a + " b:" + b);
            Swap(ref a, ref b);
            Console.WriteLine("a: " + a + " b:" + b);

            int[] arr = { 2, 3, 4, 1, 8, 6, 5, 7 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Swap(ref arr[2], ref arr[3]);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
