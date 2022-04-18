using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int d100 = int.Parse(Console.ReadLine());
            int d10 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= d100; i += 2)
            {
                for (int k = 2; k <= d10; k++)
                {
                    bool kIsPrime = true;
                    for (int l = 2; l <= k / 2 + 1; l++)
                    {
                        if (k % l == 0 && k != 2)
                        {
                            kIsPrime = false;
                            break;
                        }
                    }
                    for (int j = 2; j <= d1; j += 2)
                    {
                        if (!kIsPrime)
                        {
                            break;
                        }
                        Console.WriteLine($"{i} {k} {j}");
                    }
                }
            }
        }
    }
}
