using System;

namespace _07._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gas" || fuel == "gasoline")
            {
                if (amount >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}
