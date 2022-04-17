using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int allFens = int.Parse(Console.ReadLine());
            int numFens = int.Parse(Console.ReadLine());
            double sekA = 0;
            double sekB = 0;
            double sekV = 0;
            double sekG = 0;

            for (int i = 0; i < numFens; i++)
            {
                string sek = Console.ReadLine();
                switch (sek)
                {
                    case "A":
                        sekA++;
                        break;
                    case "B":
                        sekB++;
                        break;
                    case "V":
                        sekV++;
                        break;
                    case "G":
                        sekG++;
                        break;



                }
            }
            double percendA = sekA / numFens * 100.0;
            double percendB = sekB / numFens * 100.0;
            double percendV = sekV / numFens * 100.0;
            double percendG = sekG / numFens * 100.0;
            Console.WriteLine($"{percendA:f2}%");
            Console.WriteLine($"{percendB:f2}%");
            Console.WriteLine($"{percendV:f2}%");
            Console.WriteLine($"{percendG:f2}%");
            double oll = sekA + sekB + sekG + sekV;
            double allProcend = oll / allFens * 100.0;
            Console.WriteLine($"{allProcend:f2}%");
        }
    }
}
