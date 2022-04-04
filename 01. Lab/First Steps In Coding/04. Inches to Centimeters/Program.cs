using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Double.Parse(Console.ReadLine());
            double centimeters = num * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
