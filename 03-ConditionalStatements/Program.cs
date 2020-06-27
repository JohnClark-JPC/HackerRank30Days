using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            //int N = Int32.Parse(Console.ReadLine());
           
            if(N % 2 == 1 || N > 5 && N < 21 && N % 2 == 0) 
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
            //Console.ReadLine();
        }
    }
}
