using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            double pouse = int.Parse(Console.ReadLine());

            double lunch = pouse / 8;
            double rest = pouse / 4;
            double finishHours = pouse - (lunch + rest);
            double up = Math.Abs(episodeTime - finishHours);

            if (finishHours >= episodeTime)
            {

                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(up)} minutes free time.");
            }
            else
            {

                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(up)} more minutes.");
            }
        }
    }
}
    }
}
