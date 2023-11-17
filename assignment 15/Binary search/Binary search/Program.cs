using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class Program
    {
        
            public class BinarySearch
        {
            public static int Search(int[] array, int target)
            {
                int low = 0;
                int high = array.Length - 1;

                while (low <= high)
                {
                    int mid = low + (high - low) / 2;

                    if (array[mid] == target)
                    {
                        return mid;
                    }
                    else if (array[mid] < target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }

                return -1;
            }

            public static void Main(string[] args)
            {
                int[] array = { 2, 4, 5, 1, 3 };
                int target = 4;

                int index = Search(array, target);

                if (index != -1)
                {
                    Console.WriteLine("Element found at index: " + index);
                }
                else
                {
                    Console.WriteLine("Element not found in the array.");
                }
                Console.ReadKey();
            }
        }
    }

}
