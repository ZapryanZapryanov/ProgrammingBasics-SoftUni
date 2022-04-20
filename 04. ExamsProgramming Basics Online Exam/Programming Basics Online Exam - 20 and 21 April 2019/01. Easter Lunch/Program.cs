using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double bread = 3.2;
            double eggs = 4.35; 
            double biscuits = 5.4;
            double paint = 0.15; 

            int breadCount = int.Parse(Console.ReadLine());
            int eggsCount = int.Parse(Console.ReadLine());
            int biscuitsKgs = int.Parse(Console.ReadLine());

            double totalSum = bread * breadCount + eggs * eggsCount + biscuits * biscuitsKgs + eggsCount * 12 * paint;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
