using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorAll = int.Parse(Console.ReadLine());
            int numFloor = int.Parse(Console.ReadLine());


            for (int a1 = floorAll; a1 >= 1; a1--)
            {
                for (int a2 = 0; a2 < numFloor; a2++)
                {
                    if (a1 == floorAll)
                    {
                        Console.Write($"L{a1}{a2} ");
                    }
                    else if (a1 % 2 == 0)
                    {
                        Console.Write($"O{a1}{a2} ");
                    }
                    else
                    {
                        Console.Write($"A{a1}{a2} ");
                    }

                }
                Console.WriteLine();

            }
        }
    }
}
