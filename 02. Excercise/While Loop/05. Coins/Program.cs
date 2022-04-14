using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double convector = money * 100;
            int cents = (int)convector;
            double sum = 0;

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    sum++;
                    cents -= 200;

                }
                else if (cents - 100 >= 0)
                {
                    sum++;
                    cents -= 100;

                }
                else if (cents - 50 >= 0)
                {
                    sum++;
                    cents -= 50;

                }
                else if (cents - 20 >= 0)
                {
                    sum++;
                    cents -= 20;

                }
                else if (cents - 10 >= 0)
                {
                    sum++;
                    cents -= 10;

                }
                else if (cents - 5 >= 0)
                {
                    sum++;
                    cents -= 5;

                }
                else if (cents - 2 >= 0)
                {
                    sum++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    sum++;
                    cents -= 1;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
