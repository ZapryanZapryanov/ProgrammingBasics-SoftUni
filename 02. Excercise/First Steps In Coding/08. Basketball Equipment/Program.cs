using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double trainersPrice = taxPerYear - 0.4 * taxPerYear;
            double team = trainersPrice - 0.2 * trainersPrice;
            double ballPrice = team / 4;
            double accessories = ballPrice / 5;
            double totalCost = taxPerYear + trainersPrice + team + ballPrice + accessories;
            Console.WriteLine(totalCost);

        }
    }
}
