using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int heartstone = 0;
            int fornine = 0;
            int overwatch = 0;
            int others = 0;

            for (int i = 1; i <= n; i++)
            {
                string nameGames = Console.ReadLine();
                switch (nameGames)
                {
                    case "Hearthstone":
                        heartstone++;
                        break;
                    case "Fornite":
                        fornine++;
                        break;
                    case "Overwatch":
                        overwatch++;
                        break;
                    default:
                        others++;
                        break;
                }
            }
            double percendH = (double)heartstone / n * 100.0;
            double percendF = (double)fornine / n * 100.0;
            double percendo = (double)overwatch / n * 100.0;
            double percendOthers = (double)others / n * 100.0;
            Console.WriteLine($"Hearthstone - {percendH:f2}%");
            Console.WriteLine($"Fornite - {percendF:f2}%");
            Console.WriteLine($"Overwatch - {percendo:f2}%");
            Console.WriteLine($"Others - {percendOthers:f2}%");
        }
    }
}
