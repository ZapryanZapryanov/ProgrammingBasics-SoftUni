using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int numJuniors = int.Parse(Console.ReadLine());
            int numSeniors = int.Parse(Console.ReadLine());
            string terrain = Console.ReadLine();

            double allBikers = numJuniors + numSeniors;
            double price = 0;

            if (terrain == "trail")
            {
                price = (numJuniors * 5.5) + (numSeniors * 7);
                price *= 0.95;
            }
            if (terrain == "cross-country")
            {
                price = (numJuniors * 8) + (numSeniors * 9.50);
                price *= 0.95;
            }
            if (terrain == "downhill")
            {
                price = (numJuniors * 12.25) + (numSeniors * 13.75);
                price *= 0.95;
            }
            if (terrain == "road")
            {
                price = (numJuniors * 20) + (numSeniors * 21.50);
                price *= 0.95;
            }
            else if (terrain == "cross-country" && allBikers >= 50)
            {
                price = (numJuniors * 8) + (numSeniors * 9.50);
                price *= 0.95;
                price *= 0.75;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
