using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

           

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {(budget * 0.35):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(budget * 0.65):f2}");
                }
            }
            if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if (season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {(budget * 0.45):f2}");
                }
                else if (season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(budget * 0.80):f2}");
                }
            }
            if (budget > 500)
            {
                Console.WriteLine("Luxury class");
                if (season == "Summer" || season == "Winter")
                {
                    Console.WriteLine($"Jeep - {(budget * 0.90):f2}");
                }
            }
        }
    }
}
