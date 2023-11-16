using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        public static int ReadInt()
        {
            string temp = Console.ReadLine();
            return int.Parse(temp);
        }

        static void Main(string[] args)
        {
            int a, b, c;

            try
            {
                Console.WriteLine("Enter an int: ");
                a = ReadInt();
                Console.WriteLine("Enter an int: ");
                b = ReadInt();
                c = a / b;
                Console.WriteLine(c);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally invoked");
            }


        }
    }
}
