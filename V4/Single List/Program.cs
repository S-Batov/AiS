using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.InsertFront("Ivo");
            list.InsertEnd(1);
            list.InsertEnd(3.14);
            list.InsertFront(true);
            list.InsertEnd(100m);
            list.Display();
            Console.WriteLine("------------");
            try
            {
                list.RemoveEnd();
                list.RemoveFront();
                list.Display();

                Console.WriteLine("------------");
                list.RemoveEnd();
                list.RemoveFront();
                list.RemoveFront();
                list.Display();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
