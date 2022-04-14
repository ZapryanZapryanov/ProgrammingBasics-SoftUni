using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyEx = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int days = 0;
            int spendDays = 0;


            while (spendDays != 5)
            {
                string input = Console.ReadLine();
                double saveMoney = double.Parse(Console.ReadLine());

                days++;
                if (input == "save")
                {
                    money += saveMoney;
                    spendDays = 0;

                }
                else if (input == "spend")
                {

                    spendDays++;
                    if (money < saveMoney)
                    {
                        money = 0;
                    }
                    else
                    {
                        money -= saveMoney;
                    }
                }

                if (money >= moneyEx)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }


            }
            if (spendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }

        }
    }
}
