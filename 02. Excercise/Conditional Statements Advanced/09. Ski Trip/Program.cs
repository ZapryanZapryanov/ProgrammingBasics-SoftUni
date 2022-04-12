using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roomForOnePrison = 18.00;
            const double apartment = 25.00;
            const double presideApartament = 35.00;

            int dayPrison = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double price = dayPrison - 1;
            double total = 0;
            switch (room)
            {
                case "room for one person":
                    total = price * roomForOnePrison;
                    break;
                case "apartment":
                    total = price * apartment;
                    if (dayPrison < 10)
                    {
                        total -= total * 0.30;
                    }
                    else if (dayPrison > 10 && dayPrison < 15)
                    {
                        total -= total * 0.35;
                    }
                    else if (dayPrison > 15)
                    {
                        total -= total * 0.50;
                    }
                    break;
                case "president apartment":
                    total = price * presideApartament;
                    if (dayPrison < 10)
                    {
                        total -= total * 0.10;
                    }
                    else if (dayPrison > 10 && dayPrison < 15)
                    {
                        total -= total * 0.15;
                    }
                    else if (dayPrison > 15)
                    {
                        total -= total * 0.20;
                    }
                    break;


            }
            if (evaluation == "positive")
            {
                total += total * 0.25;
            }
            else if (evaluation == "negative")
            {
                total -= total * 0.10;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
