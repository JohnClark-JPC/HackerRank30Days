using Microsoft.VisualBasic;
using System;

namespace _01_hrDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank ";

            // Declare second integer, double, and String variables.

            int si;
            double sd;
            string ss;

            // Read and save an integer, double, and String to your variables.

            si = int.Parse(Console.ReadLine());
            sd = double.Parse(Console.ReadLine());
            ss = Console.ReadLine();

            // Print the sum of both integer variables on a new line.

            Console.WriteLine(i + si);


            // Print the sum of the double variables on a new line.

            Console.WriteLine("{0:.0}", d + sd);

            // Concatenate and print the String variables on a new line

            Console.WriteLine("{0}" + "{1}", s, ss);

            // The 's' variable above should be printed first.
        }
    }
}
