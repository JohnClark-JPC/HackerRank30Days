using System;

namespace hrRunningTimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int n = Int32.Parse(Console.ReadLine());

                if(n >= 2 && Prime(n))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }

        public static bool Prime(int n)
        {
            for (int i = 2; (i * i) <= (n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
