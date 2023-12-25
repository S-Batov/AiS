using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Sort
{
    delegate bool Comparison(object lhs, object rhs);
    internal class Quick
    {
        public static void Sort(object[] array,
                                int left,
                                int right,
                                Comparison cmp)
        {
            if (left >= right) return;
            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }
        public static int Partition(object[] array,
                                int left,
                                int right,
                                Comparison cmp)
        {
            int pivot_index = left;
            object pivot = array[pivot_index];
            for(int i = pivot_index + 1; i < right; i++)
            {
                if (cmp(array[i], pivot))
                {
                    pivot_index++;
                    Swap(array, pivot_index, i);
                }
            }
            Swap(array, left, pivot_index);

            return pivot_index;
        }
        private static void Swap(object[] array, int first, int second)
        {
            object temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
