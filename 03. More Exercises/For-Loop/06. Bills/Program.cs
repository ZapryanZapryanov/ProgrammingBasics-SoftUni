using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double tok = 0;
            double others = 0;

            for (int i = 1; i <= n; i++)
            {
                double moneyMother = double.Parse(Console.ReadLine());
                tok += moneyMother;
                others += (moneyMother + 20 + 15) + (moneyMother + 20 + 15) * 0.20;
            }
            Console.WriteLine($"Electricity: {tok:f2} lv");
            double voda = n * 20;
            double internet = n * 15;
            Console.WriteLine($"Water: {voda:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            double finaly = (tok + voda + internet + others) / n;
            Console.WriteLine($"Average: {finaly:f2} lv");
        }
    }
}
