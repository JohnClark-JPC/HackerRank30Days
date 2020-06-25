using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Transactions;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            string CombinedEntry;

            Console.WriteLine("Enter number of entries: ");
            int numberOfEntries = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                Console.WriteLine("Enter name space number: ");
                CombinedEntry = Console.ReadLine();
                string[] separatedWords = CombinedEntry.Split(' ');
                myDictionary.Add(separatedWords[0], separatedWords[1]);
            }
            
            string queryEntry;

            while ((queryEntry = Console.ReadLine()) != null)
            {
                try
                {
                    Console.WriteLine("Enter query: ");
                    queryEntry = Console.ReadLine();
                    Console.WriteLine(queryEntry + "=" + myDictionary[queryEntry]);
                }
                catch
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
