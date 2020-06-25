using System;
using System.Collections.Generic;

namespace hrGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    static void PrintArray<T>(T[] array)
    {
        foreach (T i in array)
			{
            Console.WriteLine(i);
			}
    }
}
