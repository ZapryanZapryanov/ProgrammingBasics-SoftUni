using System;

namespace _06._Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speedInfo = double.Parse(Console.ReadLine());


            bool slow = speedInfo <= 10;
            bool average = speedInfo <= 50;
            bool fast = speedInfo <= 150;
            bool ultraFast = speedInfo <= 1000;
            if (slow)
            {
                Console.WriteLine("slow");
            }
            else if (average)
            {
                Console.WriteLine("average");
            }
            else if (fast)
            {
                Console.WriteLine("fast");
            }
            else if (ultraFast)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }

        }
    }
}
