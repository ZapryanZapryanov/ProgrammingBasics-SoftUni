using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int proccesor = int.Parse(Console.ReadLine());
            int ramPamet = int.Parse(Console.ReadLine());

            double videoCardMoney = videoCard * 250;
            double proccesorMoney = videoCardMoney * 0.35;
            double ramPametMoney = videoCardMoney * 0.10;
            double allMoney = videoCardMoney + proccesorMoney * proccesor + ramPametMoney * ramPamet;



            if (videoCard > proccesor)
            {
                allMoney *= 0.85;
            }

            double finish = Math.Abs(allMoney - budge);
            if (budge >= allMoney)
            {


                Console.WriteLine($"You have {finish:f2} leva left!");

            }
            else
            {

                Console.WriteLine($"Not enough money! You need {finish:f2} leva more!");
            }
        }
    }
}
