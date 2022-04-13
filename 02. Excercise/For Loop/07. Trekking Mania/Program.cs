using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGroup = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;



            for (int i = 1; i <= numGroup; i++)
            {

                int numGroupIn = int.Parse(Console.ReadLine());


                if (numGroupIn < 6)
                {
                    musala += numGroupIn;
                }
                else if (numGroupIn < 13)
                {
                    monblan += numGroupIn;
                }
                else if (numGroupIn < 26)
                {
                    kilimandjaro += numGroupIn;
                }
                else if (numGroupIn < 41)
                {
                    k2 += numGroupIn;
                }
                else
                {
                    everest += numGroupIn;
                }


            }
            int all = musala + monblan + kilimandjaro + k2 + everest;
            double priceMusala = 1.0 * musala / all * 100;
            double priceMonblan = 1.0 * monblan / all * 100;
            double priceKili = 1.0 * kilimandjaro / all * 100;
            double priceK2 = 1.0 * k2 / all * 100;
            double priceEverest = 1.0 * everest / all * 100;

            Console.WriteLine($"{priceMusala:f2}%");
            Console.WriteLine($"{priceMonblan:f2}%");
            Console.WriteLine($"{priceKili:f2}%");
            Console.WriteLine($"{priceK2:f2}%");
            Console.WriteLine($"{priceEverest:f2}%");
        }
    }
}
