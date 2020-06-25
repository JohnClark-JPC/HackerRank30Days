using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace hrMoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {




        }
        class Calculator

        {
            int n = 0;
            int p = 0;
            int power = 0;

            public Calculator(int n, int p)
            {
                //Calculator c = new Calculator(n, p);
                


                try
                {
                    while (p > 0)
                    {
                        power *= n;
                        p--;
                    }
                    //return power;
                }

                catch (Exception e)
                    {
                        Console.WriteLine("n and p should be non-negative");
                    }

            }
        }
    }
}   
    
 
