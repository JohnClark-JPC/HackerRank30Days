using System;

namespace hrExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            string S = Console.ReadLine();
            //convert.ToInt32(S);
            try
            {
                Convert.ToInt32(S);
                Console.WriteLine(S);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
