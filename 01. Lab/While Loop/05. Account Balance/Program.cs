using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();

            double price = 0;

            while (money != "NoMoreMoney")
            {

                double currAmount = double.Parse(money);
                if (currAmount < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }
                price += currAmount;
                Console.WriteLine($"Increase: {currAmount:f2}");
                money = Console.ReadLine();

            }

            Console.WriteLine($"Total: {price:f2}");
        }
    }
}
