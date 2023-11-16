using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int FibonacciIter(int n)
        {
            if (n <=2) return 1;

            int prev_1 = 1;
            int prev_2 = 1;

            int curr = 0;
            for(int i = 0; i < n - 2; i++)
            {
                curr = prev_1 + prev_2;
                prev_1 = prev_2;
                prev_2 = curr;
            }

            return curr;
        }

        static void Main(string[] args)
        {
            int result = Factorial(6);
            Console.WriteLine("Result: " + result);

            result = Fibonacci(6);
            Console.WriteLine("Result: " + result);

            result = FibonacciIter(6);
            Console.WriteLine("Result: " + result);
        }
    }
}
