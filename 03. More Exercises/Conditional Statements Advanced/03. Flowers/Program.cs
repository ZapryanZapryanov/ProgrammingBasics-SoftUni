using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChrysanthemum = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string offDay = Console.ReadLine();

            double price = 0;
            double allFlowers = numChrysanthemum + numRoses + numTulips;

            if (season == "Spring" || season == "Summer")
            {
                price = (numChrysanthemum * 2.00) + (numRoses * 4.10) + (numTulips * 2.50);
            }
            if (season == "Autumn" || season == "Winter")
            {
                price = (numChrysanthemum * 3.75) + (numRoses * 4.50) + (numTulips * 4.15);
            }
            if (numTulips > 7 && season == "Spring")
            {
                price *= 0.95;
            }
            if (numRoses >= 10 && season == "Winter")
            {
                price *= 0.90;
            }
            if (offDay == "Y")
            {
                price *= 1.15;
            }
            if (allFlowers >= 20)
            {
                price *= 0.80;
            }
            price += 2;

            Console.WriteLine($"{price:f2}");
        }
    }
}
