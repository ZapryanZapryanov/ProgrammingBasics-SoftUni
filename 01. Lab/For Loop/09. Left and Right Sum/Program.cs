using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int finalyPrice2 = 0;
            int finaly = 0;
            int sum = 0;



            for (int i = 1; i <= n; i++)
            {

                int number1 = int.Parse(Console.ReadLine());
                finaly += number1;

            }
            for (int i = 0; i < n; i++)
            {
                int number2 = int.Parse(Console.ReadLine());
                finalyPrice2 += number2;
            }
            if (finalyPrice2 == finaly)
            {
                sum = finalyPrice2;
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                double sell = finalyPrice2 - finaly;
                Console.WriteLine($"No, diff = {Math.Abs(sell)}");
            }

        }
    }
}
