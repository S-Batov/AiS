using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    internal class Selection
    {
        public static void Sort(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
                return;
            int min = array[index];
            int min_index = index;

            for(int i = index; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min_index = i;
                    min = array[i];
                }
            }

            if(min_index != index)
            {
                int temp = array[index];
                array[index] = array[min_index];
                array[min_index] = temp;
            }

            Sort(array, index + 1);
        }
    }
}
