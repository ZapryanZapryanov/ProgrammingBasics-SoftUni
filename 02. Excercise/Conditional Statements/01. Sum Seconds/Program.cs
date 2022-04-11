using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int total = firstTime + secondTime + thirdTime;
            int minutes = total / 60;
            int second = total % 60;
            if (second < 10)
            {
                Console.WriteLine($"{minutes}:{second:d2}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{second:d2}");
            }
        }
    }
}
