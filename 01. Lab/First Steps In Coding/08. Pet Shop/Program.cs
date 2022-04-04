using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodDog = int.Parse(Console.ReadLine());
            int foodCat = int.Parse(Console.ReadLine());

            double packageDog = foodDog * 2.50;
            int packageCat = foodCat * 4;
            double allMoney = packageDog + packageCat;
            Console.Write($"" + allMoney + " lv.");
        }
    }
}
