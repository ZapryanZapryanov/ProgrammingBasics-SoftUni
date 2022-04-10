using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int percend = int.Parse(Console.ReadLine());

            double pens = countPens * 5.80;
            double markers = countMarkers * 7.20;
            double lit = liters * 1.20;
            double allMaterials = pens + markers + lit;

            double sumAfterDiskount = allMaterials - (percend / 100.0) * allMaterials;
            Console.WriteLine(sumAfterDiskount);
        }
    }
}
