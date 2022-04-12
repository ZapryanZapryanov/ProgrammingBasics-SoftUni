using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            String flowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budge = int.Parse(Console.ReadLine());
            double price = 0;

            switch (flowers)
            {
                case "Roses":
                    if (numFlowers > 80)
                    {
                        price -= numFlowers * 5 * 0.10;
                    }
                    price += numFlowers * 5;
                    break;
                case "Dahlias":
                    if (numFlowers > 90)
                    {
                        price -= numFlowers * 3.80 * 0.15;
                    }
                    price += numFlowers * 3.80;
                    break;
                case "Tulips":
                    if (numFlowers > 80)
                    {
                        price -= numFlowers * 2.80 * 0.15;
                    }
                    price += numFlowers * 2.80;
                    break;
                case "Narcissus":
                    if (numFlowers < 120)
                    {
                        price += numFlowers * 3.00 * 0.15;
                    }
                    price += numFlowers * 3.00;
                    break;
                case "Gladiolus":
                    if (numFlowers < 80)
                    {
                        price += numFlowers * 2.50 * 0.20;
                    }
                    price += numFlowers * 2.50;
                    break;

            }
            if (budge >= price)
            {
                double moneyLeft = budge - price;

                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = price - budge;
                Console.WriteLine($"Not enough money, you need {moneyNeed:f2} leva more.");

            }
        }
    }
}
