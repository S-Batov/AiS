using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void Invoker(int i);
    internal class Program
    {
        static void Method(Invoker invoker, int value)
        {
            invoker(value);
        }
        static void Display(int i )
        {
            Console.WriteLine("Displaying " + i);
        }
        static void Print(int i)
        {
            Console.WriteLine("Printing " + i);
        }
        static void Main(string[] args)
        {
            //Invoker invoker = new Invoker(Display);
            Invoker invoker = Display;

            //invoker.Invoke(1);
            invoker(1);

            invoker = Print;
            invoker(2);

            invoker += Display;
            invoker(3);

            Method(Display, 4);
            Method(Print, 5);

            invoker = delegate (int i)
            {
                Console.WriteLine("Anonimously: " + i);
            };
            invoker(6);

            invoker = i => Console.WriteLine("Lambdaing " + i);
            invoker(7);
        }
    }
}
