using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChikens = int.Parse(Console.ReadLine());
            int numberFish = int.Parse(Console.ReadLine());
            int numberVegitarian = int.Parse(Console.ReadLine());

            double chikens = numberChikens * 10.35;
            double fish = numberFish * 12.40;
            double vegitarian = numberVegitarian * 8.15;

            double totalPriceMenus = chikens + fish + vegitarian;
            double dessert = 0.2 * totalPriceMenus;
            double allMoney = totalPriceMenus + dessert + 2.50;
            Console.WriteLine(allMoney);
        }
    }
}
