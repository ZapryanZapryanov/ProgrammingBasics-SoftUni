using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double hous = double.Parse(Console.ReadLine());
            double meter = hous * 7.61;
            double meterDiskount = meter * (0.18);
            double exit = meter - meterDiskount;
            Console.WriteLine($"The final price is: {exit} lv. ");
            Console.WriteLine($"The discount is: {meterDiskount} lv. ");
        }
    }
}
