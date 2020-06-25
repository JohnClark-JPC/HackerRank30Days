using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace hrBubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a nubmer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a string of ints separated by a space: ");
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int numSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swap(ref a[j], ref a[j + 1]);
                        numSwaps++;  
                    }
                }
                // If no elements were swapped during a traversal, array is sorted
                if (numSwaps == 0)
                {
                    break;
                }

            }

            Console.WriteLine("Array is sorted in {0} swaps.", numSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[n - 1]);

        }
        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
