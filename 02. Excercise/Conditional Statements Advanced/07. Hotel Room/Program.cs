using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mother = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApartament = 0.0;

            switch (mother)
            {
                case "May":
                case "October":
                    priceStudio = night * 50;
                    priceApartament = night * 65;
                    if (night > 7 && night < 14)
                    {
                        priceStudio -= priceStudio * 0.05;
                    }
                    else if (night > 14)

                    {

                        priceStudio -= priceStudio * 0.30;
                    }

                    break;
                case "June":
                case "September":
                    priceStudio = night * 75.20;
                    priceApartament = night * 68.70;
                    if (night > 14)
                    {

                        priceStudio -= priceStudio * 0.20;
                    }

                    break;
                case "July":
                case "August":
                    priceStudio = night * 76;
                    priceApartament = night * 77;

                    break;


            }
            if (night > 14)
            {
                priceApartament -= priceApartament * 0.10;
            }
            Console.WriteLine($"Apartment: {priceApartament:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
