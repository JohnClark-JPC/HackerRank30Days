using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 12;

            int tip_percent = 20;

            int tax_percent = 8;

            Solve(meal_cost, tip_percent, tax_percent);

        }

        static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = meal_cost * Convert.ToDouble(tip_percent) / 100;
            double tax = meal_cost * Convert.ToDouble(tax_percent) /100;
            double totalCost = meal_cost + tip + tax;
            int total = Convert.ToInt32(totalCost);
            Console.WriteLine(total);
            
        
           
        }

    }

}
