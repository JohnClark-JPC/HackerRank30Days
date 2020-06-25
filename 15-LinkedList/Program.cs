using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http.Headers;

namespace hrLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of linked list: ");
            int t = Convert.ToInt32(Console.ReadLine());
            LinkedList<int> myLinkedList = new LinkedList<int>();

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Enter number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                myLinkedList.AddLast(x);
            }
            foreach (int i in myLinkedList)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//This solution works on HackerRank:
//if (head == null) head = new Node(data);
//        else {
//            Node curr = head;
//            while (curr.next != null) curr = curr.next;
//            curr.next = new Node(data);
//        }
//        return head;
   
