using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;

            if (km < 20 && km > 0 && dayOrNight == "day")
            {
                price = (0.70 + (km * 0.79));
            }
            else if (km < 20 && km > 0 && dayOrNight == "night")
            {
                price = (0.70 + (km * 0.90));
            }
            else if (km >= 100 && km < 5001 && dayOrNight == "day")
            {
                price = (km * 0.06);
            }
            else if (km >= 100 && km < 5001 && dayOrNight == "night")
            {
                price = (km * 0.06);
            }
            else if (km >= 20 && km < 100 && dayOrNight == "day")
            {
                price = (km * 0.09);
            }
            else if (km >= 20 && km < 100 && dayOrNight == "night")
            {
                price = (km * 0.09);
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
