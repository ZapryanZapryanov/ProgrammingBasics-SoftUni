using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            String season = Console.ReadLine();
            double price = 0;

            if (season == "summer")
            {
                if (budge <= 100)
                {
                    price = 0.30 * budge;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {price:f2}");
                }
                else if (budge <= 1000)
                {
                    price = 0.40 * budge;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {price:f2}");
                }
                else
                {
                    price = 0.90 * budge;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {price:f2}");
                }

            }
            else if (season == "winter")
            {
                if (budge <= 100)
                {
                    price = 0.70 * budge;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {price:f2}");
                }
                else if (budge <= 1000)
                {
                    price = 0.80 * budge;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {price:f2}");
                }
                else
                {
                    price = 0.90 * budge;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {price:f2}");
                }
            }
        }
    }
}
