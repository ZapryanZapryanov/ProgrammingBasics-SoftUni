using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double pricePeral = double.Parse(Console.ReadLine());
            int play = int.Parse(Console.ReadLine());
            double toys = 0;
            double money = 0;
            double totalMoney = 0;


            for (int i = 1; i <= age; i++)
            {
                money += 5;
                if (i % 2 == 0)
                {
                    totalMoney += money - 1;
                }
                else
                {
                    toys++;
                }
            }

            double Pricetoys = toys * play;
            double allMoney = Pricetoys + totalMoney;
            if (pricePeral <= allMoney)
            {
                double exit = allMoney - pricePeral;
                Console.WriteLine($"Yes! {exit:f2}");
            }
            else
            {
                double no = pricePeral - allMoney;
                Console.WriteLine($"No! {no:f2}");
            }
        }
    }
}
