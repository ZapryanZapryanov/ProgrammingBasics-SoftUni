using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNylon = int.Parse(Console.ReadLine());
            int quantityPaint = int.Parse(Console.ReadLine());
            int quantityDiuluent = int.Parse(Console.ReadLine());
            int workHour = int.Parse(Console.ReadLine());
            double priceNylon = (quantityNylon + 2) * 1.50;
            double pricePaint = (quantityPaint + 0.10 * quantityPaint) * 14.50;
            double priceDiuluend = quantityDiuluent * 5;
            double pricehours = 0.30 * (priceNylon + pricePaint + priceDiuluend + 0.40);

            double priceWork = workHour * pricehours;
            double expenses = priceNylon + pricePaint + priceDiuluend + 0.40 + priceWork;
            Console.WriteLine(expenses);
        }
    }
}
