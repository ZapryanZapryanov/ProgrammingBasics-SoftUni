using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum = 0;
            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                sum = 0;
                for (int j = 01; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        sum += 1;
                        total += 1;
                    }
                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        sum += 1;
                        total += 1;
                    }
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        sum += 2.50;
                        total += 2.50;
                    }
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        sum += 1.25;
                        total += 1.25;
                    }
                }
                Console.WriteLine($"Day: {i} - {sum:f2} leva");
            }
            Console.WriteLine($"Total: {total:f2} leva");

        }
    }
}
