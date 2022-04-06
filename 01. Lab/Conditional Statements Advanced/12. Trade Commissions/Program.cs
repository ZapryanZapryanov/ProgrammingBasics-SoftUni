using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double price = 0;


            if (city == "Sofia" && sales >= 10 % 2)
            {
                if (sales >= 0 && sales <= 500)
                {
                    price = 0.05;
                    Console.WriteLine($"{(sales * price):f2}");
                }
                else if (sales <= 1000)
                {
                    price = 0.07;
                    Console.WriteLine($"{(sales * price):f2}");
                }
                else if (sales <= 10000)
                {
                    price = 0.08;
                    Console.WriteLine($"{(sales * price):f2}");
                }
                else if (sales > 10000)
                {
                    price = 0.12;
                    Console.WriteLine($"{(sales * price):f2}");
                }

            }
            else if (city == "Plovdiv" && sales >= 10 % 2)
            {

                if (sales <= 500)
                {
                    price = 0.055;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else if (sales > 0 && sales <= 1000)
                {
                    price = 0.08;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else if (sales <= 10000)
                {
                    price = 0.12;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else if (sales > 10000)
                {
                    price = 0.145;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else if (sales == -20)
                {
                    Console.WriteLine("error");
                }


            }
            else if (city == "Varna" && sales >= 10 % 2)
            {
                if (sales >= 0 && sales <= 500)
                {
                    price = 0.045;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else if (sales <= 1000)
                {
                    price = 0.075;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else if (sales <= 10000)
                {
                    price = 0.1;
                    Console.WriteLine($"{sales * price:f2}");
                }
                else
                {
                    price = 0.13;
                    Console.WriteLine($"{sales * price:f2}");
                }

            }

            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
