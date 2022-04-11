using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double monewFilm = double.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            double dekor = monewFilm * 0.10;
            double cloth = num * clothing;




            if (num > 150)
            {
                cloth *= 0.90;
            }

            double total = dekor + cloth;

            if (total > monewFilm)
            {
                double needMoney = total - monewFilm;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");

            }
            else
            {
                double money = monewFilm - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money:f2} leva left.");
            }
        }
    }
}
