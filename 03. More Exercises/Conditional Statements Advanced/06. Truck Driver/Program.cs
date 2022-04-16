using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmMonth = double.Parse(Console.ReadLine());

            double price = 0;
            double tax = 0;

            if (kmMonth <= 5000)
            {
                if (season == "Summer")
                {
                    price = kmMonth * 0.90;
                    tax = (price * 4) * 0.90;
                }
                else if (season == "Winter")
                {
                    price = kmMonth * 1.05;
                    tax = (price * 4) * 0.90;
                }
                else if (season == "Autumn" || season == "Spring")
                {
                    price = kmMonth * 0.75;
                    tax = (price * 4) * 0.90;
                }
            }
            if (kmMonth > 5000 && kmMonth <= 10000)
            {
                if (season == "Summer")
                {
                    price = kmMonth * 1.10;
                    tax = (price * 4) * 0.90;
                }
                else if (season == "Winter")
                {
                    price = kmMonth * 1.25;
                    tax = (price * 4) * 0.90;
                }
                else if (season == "Autumn" || season == "Spring")
                {
                    price = kmMonth * 0.95;
                    tax = (price * 4) * 0.90;
                }
            }
            if (kmMonth > 10000 && kmMonth <= 20000)
            {
                if (season == "Summer" || season == "Winter" || season == "Autumn" || season == "Spring")
                {
                    price = kmMonth * 1.45;
                    tax = (price * 4) * 0.90;
                }
            }
            Console.WriteLine($"{tax:f2}");
        }
    }
}
