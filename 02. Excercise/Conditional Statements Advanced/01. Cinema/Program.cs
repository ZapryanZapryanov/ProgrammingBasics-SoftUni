using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            const double premiere = 12.00;
            const double normal = 7.50;
            const double discount = 5.00;

            string project = Console.ReadLine();
            int numLine = int.Parse(Console.ReadLine());
            int numCollons = int.Parse(Console.ReadLine());
            double price = 0;

            switch (project)
            {
                case "Premiere":
                    price = premiere * numLine * numCollons;
                    Console.WriteLine($"{price:f2} leva");
                    break;
                case "Normal":
                    price = normal * numLine * numCollons;
                    Console.WriteLine($"{price:f2} leva");
                    break;
                case "Discount":
                    price = Discount * numLine * numCollons;
                    Console.WriteLine($"{price:f2} leva");
                    break;

            }
        }
    }
}
