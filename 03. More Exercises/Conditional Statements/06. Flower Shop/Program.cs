using System;

namespace _06._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMagnolia = int.Parse(Console.ReadLine());
            int numHyacinth = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numCactus = int.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());

            double total = (numMagnolia * 3.25) + (numHyacinth * 4) + (numRoses * 3.50) + (numCactus * 8);
            double taxes = total * 0.05;
            double profit = total - taxes;

            if (present > profit)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(present - profit)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - present)} leva.");
            }
        }
    }
}
