using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            bool flag = num >= 5.50;

            if (flag)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
