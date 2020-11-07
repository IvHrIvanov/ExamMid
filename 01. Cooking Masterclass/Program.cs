using System;
using System.Runtime.InteropServices;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceFgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            int freeFlour = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freeFlour++;
                }

            }

            double apron = priceApron * (Math.Ceiling(students + students * 0.2));
            double eggs = priceFgg * 10 * students;
            double flour = priceFlour * (students - freeFlour);

            double totalSum = apron + eggs + flour;

            if (totalSum <= budget)
            {
                Console.WriteLine($"Items purchased for {totalSum:f2}$.");
            }
            else
            {
                double needetMoney = totalSum - budget;
                Console.WriteLine($"{needetMoney:f2}$ more needed.");
            }

        }
    }
}
