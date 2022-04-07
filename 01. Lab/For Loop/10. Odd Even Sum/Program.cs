using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    second += num;
                }
                else
                {
                    first += num;
                }
            }

            if (first == second)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {second}");
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(first - second) }");

            }
        }
    }
}
