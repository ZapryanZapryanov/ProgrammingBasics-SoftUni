using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int work = 365 - daysOff;

            int totalPlay = work * 63 + daysOff * 127;

            int diff = Math.Abs(30000 - totalPlay);
            int hours = diff / 60;
            int minutes = diff % 60;

            if (30000 > totalPlay)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
