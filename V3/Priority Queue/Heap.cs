using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    internal class Heap
    {
        private int size;
        private int last;
        private int[] priorities;

        public Heap(int size)
        {
            this.size = size;
            priorities = new int[size + 1];
            last = 0;
        }

        public void Insert(int elem)
        {
            if (last >= size) throw new Exception("Queue is full");
            priorities[++last] = elem;

            BubbleUp(last);
        }
        public int Retrieve()
        {
            if(last == 0) throw new Exception("Queue is empty!");

            int ret = priorities[0];
            priorities[0] = priorities[last--];
            BubbleDown(1);
            return ret;
        }
        public void BubbleUp(int i)
        {
            if (i == 1) return;
            int parent = i / 2;
            if (priorities[i] > priorities[parent])
            {
                Swap(i, parent);
                BubbleUp(parent);
            }
        }
        public void BubbleDown(int i)
        {
            int child = 2 * i;

            if (child < last
                && priorities[child] < priorities[child + 1])
                child++;

            if(child <= last
               && priorities[i] < priorities[child])
            {
                Swap(i, child);
                BubbleDown(child);
            }
        }
        private void Swap(int first, int second)
        {
            int temp = priorities[first];
            priorities[first] = priorities[second];
            priorities[second] = temp;
        }
        public void Display()
        {
            for(int i = 1;  i <= last; i++)
                Console.Write(priorities[i] + " ");
            Console.WriteLine();
        }
    }
}
