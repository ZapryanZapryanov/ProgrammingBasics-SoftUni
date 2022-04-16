using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transport = 0.00;
            double tickets = 0.00;
            double left = 0.00;

            if (people >= 1 && people <= 4) transport = budget * 0.75;


            else if (people >= 5 && people <= 9) transport = budget * 0.60;


            else if (people >= 10 && people <= 24) transport = budget * 0.50;


            else if (people >= 25 && people <= 49) transport = budget * 0.40;


            else if (people >= 50) transport = budget * 0.25;

            if (category == "Normal")
            {
                tickets = people * 249.99;
                left = budget - transport - tickets;
            }
            else if (category == "VIP")
            {
                tickets = people * 499.99;
                left = budget - transport - tickets;
            }

            if (left > 0)
            {
                Console.WriteLine($"Yes! You have {left:f2} leva left.");
            }
            else if (left < 0)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(left):f2} leva.");
            }

        }
    }
}
