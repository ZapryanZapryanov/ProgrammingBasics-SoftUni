using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            
            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 200)
                {
                    p1++;
                }
                else if (n < 400)
                {
                    p2++;
                }
                else if (n < 600)
                {
                    p3++;
                }
                else if (n < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double p11 = (double)p1 / number * 100;
            double p22 = (double)p2 / number * 100;
            double p33 = (double)p3 / number * 100;
            double p44 = (double)p4 / number * 100;
            double p55 = (double)p5 / number * 100;
            Console.WriteLine($"{p11:f2}%");
            Console.WriteLine($"{p22:f2}%");
            Console.WriteLine($"{p33:f2}%");
            Console.WriteLine($"{p44:f2}%");
            Console.WriteLine($"{p55:f2}%");
        }
    }
}
