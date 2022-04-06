using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            String product = Console.ReadLine();
            String dayWeek = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            double price = 0;

            if (dayWeek == "Monday" || dayWeek == "Tuesday" || dayWeek == "Wednesday" || dayWeek == "Thursday"
                || dayWeek == "Friday")
            {
                if (product == "banana")
                {
                    price = 2.50;
                    Console.WriteLine($"{quality * price:f2}");
                }

                else if (product == "apple")
                {
                    price = 1.20;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "orange")
                {
                    price = 0.85;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "kiwi")
                {
                    price = 2.70;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "pineapple")
                {
                    price = 5.50;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                    Console.WriteLine($"{quality * price:f2}");

                }
                else
                {
                    Console.WriteLine("error");

                }



            }
            else if (dayWeek == "Saturday" || dayWeek == "Sunday")
            {
                if (product == "banana")
                {
                    price = 2.70;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "apple")
                {
                    price = 1.25;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "orange")
                {
                    price = 0.90;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "grapefruit")
                {
                    price = 1.60;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "kiwi")
                {
                    price = 3.00;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "pineapple")
                {
                    price = 5.60;
                    Console.WriteLine($"{quality * price:f2}");
                }
                else if (product == "grapes")
                {
                    price = 4.20;
                    Console.WriteLine($"{quality * price:f2}");

                }
                else
                {
                    Console.WriteLine("error");

                }


            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
