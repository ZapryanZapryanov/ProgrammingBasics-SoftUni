using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budge = int.Parse(Console.ReadLine());
            String season = Console.ReadLine();
            double numRibar = double.Parse(Console.ReadLine());


            double price = 0;

            switch (season)
            {
                case "Winter":
                    price = 2600;
                    break;
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;

            }

            if (numRibar <= 6)
            {
                price -= price * 0.10;
            }
            else if (numRibar <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }


            if (numRibar % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }
            if (budge >= price)
            {
                double leftMoney = budge - price;
                Console.WriteLine($"Yes! You have {leftMoney:f2} leva left.");
            }
            else
            {
                double money = price - budge;
                Console.WriteLine($"Not enough money! You need {money:f2} leva.");
            }
        }
    }
}
