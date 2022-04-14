using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string pay = Console.ReadLine();

            int cake = width * lenght;
            int wonCake = 0;


            while (pay != "STOP")
            {
                int currutPay = int.Parse(pay);
                cake -= currutPay;
                if (cake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
                    return;
                }


                pay = Console.ReadLine();


            }

            if (pay == "STOP")
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
        }
    }
}
