using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Arrays
{
    internal class SmartArray
    {
        int size;
        int last = -1;
        int[] array;

        public SmartArray(int size_)
        {
            this.size = size_;
            this.array = new int[size_];
        }

        public int Length
        {
            get { return last; }
        }

        public void Add(int item)
        {
            if (last == (size - 1))
            {
                Array resized = Array.CreateInstance(typeof(int), size * 2);
                Array.Copy(array, resized, size);

                array = (int[])resized;
                size = array.Length;
            }

            array[++last] = item;
        }
    }
}
