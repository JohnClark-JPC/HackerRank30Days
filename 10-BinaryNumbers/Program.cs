using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;

namespace ConsoleApp6
{
    class Program
    {

        static void Main(string[] args)
        { 
            int n = Convert.ToInt32(Console.ReadLine());

            string binaryString = Convert.ToString(n, 2);
            int result = 1;
            int longestResult = 1;

            //Console.WriteLine(binaryString);

            if (binaryString == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < binaryString.Length - 1; i++)
                {
                    if (binaryString[i] == '1' && binaryString[i + 1] == '1')
                    {
                        result++;
                    }
                    else
                    {
                        if(result > longestResult)
                        {
                            longestResult = result;
                        }
                        result = 1;
                    }
                }

                if (result > longestResult)
                    {
                        longestResult = result;
                    }
            }
            Console.WriteLine(longestResult);
        } 
    }
}
