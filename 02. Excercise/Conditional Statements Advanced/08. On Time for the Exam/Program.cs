using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursIspit = int.Parse(Console.ReadLine());
            int minutesIspit = int.Parse(Console.ReadLine());
            int hoursPristigane = int.Parse(Console.ReadLine());
            int minutesPristigane = int.Parse(Console.ReadLine());

            int difference = 0;
            int hours = 0;
            int minutes = 0;

            minutesIspit += hoursIspit * 60;
            minutesPristigane += hoursPristigane * 60;
            if (minutesPristigane > minutesIspit)
            {
                Console.WriteLine("Late");
                difference = minutesPristigane - minutesIspit;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($" {hours}:{minutes:d2} hours after the start");
                }
            }
            else if (minutesPristigane < minutesIspit - 30)
            {
                Console.WriteLine($"Early");
                difference = minutesIspit - minutesPristigane;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");

                }


            }
            else
            {
                Console.WriteLine("On time");
                difference = minutesIspit - minutesPristigane;
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
    }
}
