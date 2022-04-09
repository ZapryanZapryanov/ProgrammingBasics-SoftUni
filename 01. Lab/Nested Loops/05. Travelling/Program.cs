using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string distinace = Console.ReadLine();

            while (distinace != "End")
            {
                double money = double.Parse(Console.ReadLine());
                double currMoney = 0;
                while (currMoney < money)
                {
                    currMoney += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {distinace}!");
                distinace = Console.ReadLine();
            }
        }
    }
}
