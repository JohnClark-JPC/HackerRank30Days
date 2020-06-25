using System;
using System.Security.Cryptography.X509Certificates;

namespace hrCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int power(int n, int p)
            {
                if (n < 0 || p < 0)
                {
                    throw new Exception("n and p should be non-negative");
                }
                
                int pwr = 1;
    
                while (p > 0)
                {
                    pwr *= n;
                    p--;
                } 
 
                return pwr;
            }
        }
    }
}

    

