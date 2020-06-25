using System;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace hrAbstractClass
{
    class Program
    {
        

        public abstract class Book
        {
            public Book(string title, string author)
            {
                public string title;
                public string author;
                public int price;
                public abstract void Display();
            }
            
        }

        public class MyBook : Book
        {
            int price = 0;
            public MyBook(string title, string author, int price) : base(title, author)
            {
                this.price = price;
            }
            public override void Display()
            {
                Console.WriteLine("Title: {0}",title);
                Console.WriteLine("Author: {0}", author);
                Console.WriteLine("Price: {0}", price);
            }
        } 
    }
}





            
