using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double expectedSum = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double items = 0;

            double total = 0;
            double cash = 0;
            double card = 0;
            double cardCount = 0;
            double cashCount = 0;
            double averageCash = 0;
            double averageCard = 0;
            double count = 1;

            while (command != "End")
            {
                items = double.Parse(command);
                count++;

                if (count % 2 == 0)
                {
                    if (items > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        total += items;
                        cash += items;
                        cashCount++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (items < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        total += items;
                        card += items;
                        cardCount++;
                        Console.WriteLine("Product sold!");
                    }
                }
                if (total >= expectedSum)
                {
                    averageCash = cash / cashCount;
                    averageCard = card / cardCount;
                    Console.WriteLine($"Average CS: {averageCash:f2}");
                    Console.WriteLine($"Average CC: {averageCard:f2}");
                    return;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine("Failed to collect required money for charity.");

        }
    }
}
