using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;

namespace HrInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Person
        {

        }

        public class Student : Person
        {
            private int[] testScores;

            public Student(string firstName, string lastName, int id, int[] testScores) : base(firstName, lastName, id)
            {
                this.testScores = testScores;
            }

            public char Calculate()
            {
                int total = 0;

                foreach (int testScores in testScores) total += testScores;

                int avg = total / testScores.Length;

                if (avg >= 90)
                {
                    return 'O';
                }
                if (avg >= 80)
                {
                    return 'E';
                }
                if (avg >= 70)
                {
                    return 'A';
                }
                if (avg >= 55)
                {
                    return 'P';
                }
                if (avg >= 40)
                {
                    return 'D';
                }
                return 'T';
            }
        } 
    }
}
//string firstName;
//string lastName;
//int id;
//char scores;

//public void DisplayStudent(Student)
//{
//    Console.WriteLine("Name: " + lastName +"," + firstName);
//    Console.WriteLine("ID: " + id);
//    char answer = Calculate(scores);
//    Console.WriteLine("Grade: {0}", scores);
//}
