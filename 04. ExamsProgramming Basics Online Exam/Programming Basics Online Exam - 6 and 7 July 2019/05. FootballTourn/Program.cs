using System;

namespace _05._FootballTourn
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFutbollTeams = Console.ReadLine();
            int numSeasonPlay = int.Parse(Console.ReadLine());
            if (numSeasonPlay == 0)
            {
                Console.WriteLine($"{nameFutbollTeams} hasn't played any games during this season.");
                return;
            }
            int w = 0;
            int d = 0;
            int l = 0;
            for (int i = 0; i < numSeasonPlay; i++)
            {

                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        w++;
                        break;
                    case "D":
                        d++;
                        break;
                    case "L":
                        l++;
                        break;
                }
            }
            double finalyW = w * 3;
            double finalyD = d * 1;
            Console.WriteLine($"{nameFutbollTeams} has won {finalyD + finalyW} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {w}");
            Console.WriteLine($"## D: {finalyD}");
            Console.WriteLine($"## L: {l}");
            double winsPercent = (double)w / numSeasonPlay * 100;
            Console.WriteLine($"Win rate: {winsPercent:f2}%");
        }
    }
}
