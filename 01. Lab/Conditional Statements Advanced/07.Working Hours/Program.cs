using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string dayWeek = Console.ReadLine();

            if (hours <= 18 && hours >= 10)
            {
                if (dayWeek == "Tuesday" || dayWeek == "Wednesday" || dayWeek == "Monday"
                    || dayWeek == "Friday" || dayWeek == "Saturday" || dayWeek == "Thursday")

                    Console.WriteLine("open");
                else
                {
                    Console.WriteLine("closed");
                }

            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
