using System;

namespace _05._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double dog = days * dogFood;
            double cat = days * catFood;
            double turtle = (days * turtleFood) / 1000;
            double total = dog + cat + turtle;

            if (total <= leftFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood - total)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(total - leftFood)} more kilos of food are needed.");
            }
        }
    }
}
