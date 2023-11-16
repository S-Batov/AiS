using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    internal class Program
    {
        static int SequentialSearch(int[] arr, int element)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                    return i;
            }

            return -1;
        }

        static int BinarySearch(int[]arr, int element)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = (low + high) / 2;

            while (low < high)
            {
                if (arr[mid] == element)
                    return mid;

                if (arr[mid] > element)
                {
                    high = mid;
                    mid = (low + high) / 2;
                }
                else
                {
                    low = mid;
                    mid = (high + low) / 2;
                }
            }

            return -1;
        }

        static int BinarySearch(int[] arr, int element, int low_, int high_)
        {
            int low = low_; 
            int high = high_;
            int mid = (low + high) / 2;

            if (low >= high)
                return -1;

            if (arr[mid] == element)
            {
                return mid;
            }
            else if (arr[mid] > element)
            {
                high = mid;
                mid = (low + high) / 2;
                return BinarySearch(arr, mid, low, high);
            }
            else // arr[mid] < element
            {
                low = mid;
                mid = (low + high) / 2;
                return BinarySearch(arr, element, low, high);
            }


        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            int index = SequentialSearch(array, 6);
            Console.WriteLine("Index: " + index);

            index = BinarySearch(array, 6);
            Console.WriteLine("Index: " + index);

            index = BinarySearch(array, 6, 0, array.Length - 1);
            Console.WriteLine("Index: " + index);
        }
    }
}
