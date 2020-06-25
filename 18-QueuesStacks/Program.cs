using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;

namespace hrQueuesStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> s = new Stack<char>();
            Queue<char> q = new Queue<char>();

            void pushCharacter(char ch)
            {
                    s.Push(ch); 
            }
            //void enqueueCharacter char method the enqueues char in queue instance variable
            void enqueueCharacter(char ch)
            {          
                q.Enqueue(ch);
            }

            //char popCharacter() method that pops and return char at top the stack instance variable

            char popCharacter()
            {
                char ch = s.Pop();
                return ch;
            }

            //char dequeueCharacter() method that dequeues and returns first char in queue instance variable

            char dequeueCharacter()
            {
                char ch = q.Dequeue();
                return ch;
            }

            Console.WriteLine("Enter a word");
            string st = Console.ReadLine();
            foreach (char c in st)
            {
                pushCharacter(c);
                enqueueCharacter(c);
            }

            bool palindrome = true;

            for (int i = 0; i < st.Length / 2; i++)
            {
                if (popCharacter() != dequeueCharacter())
                {
                    palindrome = false;
                    break;
                }
            }

            if (palindrome)
            {
                Console.WriteLine("The word, {0}, is a palindrome.", st);
            }
            else
            {
                Console.WriteLine("The word, {0}, is not a palindrome.", st);
            }

        }

    }
}
