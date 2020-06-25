using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace HrScope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Difference
        {
            int[] elements;
            public int maximumDifference;

            public Difference(int[] elements)
            {
                this.elements = elements;
            }

            // iterate through the numbers to find max difference.
            public void computeDifference()
            {
                int min = 100;
                int max = 0;
                int maximumDifference = 0;
                for (int i = 0; i < elements.Length; i++)
                { 
                    for (int t = 0; t < elements.Length; t++)
                    {
                        if (elements[i] < min)
                        {
                            min = elements[i];
                        }
                        if (elements[t] > max)
                        {
                            max = elements[t];
                        }
                    }
                }
                maximumDifference = max - min;
            }
        }
    }
}
