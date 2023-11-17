using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    internal class Program
    {

            public class BubbleSort
        {
            public static void Sort(int[] array)
            {
                bool isSwapped;

                do
                {
                    isSwapped = false;

                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                            isSwapped = true;
                        }
                    }
                } while (isSwapped);
            }

            public static void Main(string[] args)
            {
                int[] array = { 5, 2, 4, 1, 3 };

                Console.WriteLine("Unsorted array:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }

                Sort(array);

                Console.WriteLine("\nSorted array:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.ReadKey();
            }
        }

    }
}
    
