using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double secondRecord = double.Parse(Console.ReadLine());
            double meter = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            double second15m = Math.Floor(meter / 15) * 12.5;
            double allTime = meter * second + second15m;


            if (secondRecord > allTime)
            {
                double finish = allTime;
                Console.WriteLine($"Yes, he succeeded! The new world record is {finish:f2} seconds.");
            }


            else
            {

                double recordWin = allTime - secondRecord;
                Console.WriteLine($"No, he failed! He was {recordWin:f2} seconds slower.");

            }
        }
    }
}
