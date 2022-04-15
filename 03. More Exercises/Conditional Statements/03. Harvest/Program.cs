using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = double.Parse(Console.ReadLine());
            var grape = double.Parse(Console.ReadLine());
            var neededLiters = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());

            var harvest = vineyard * grape * 0.4;
            var liters = harvest / 2.5;

            if (liters >= neededLiters)
            {
                var leftWine = liters - neededLiters;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(liters)} liters.");
                Console.WriteLine($"{Math.Ceiling(leftWine)} liters left -> " +
                    $"{Math.Ceiling(leftWine / workers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! " +
                    $"More {Math.Floor(neededLiters - liters)} liters wine needed.");
            }
        }
    }
}
