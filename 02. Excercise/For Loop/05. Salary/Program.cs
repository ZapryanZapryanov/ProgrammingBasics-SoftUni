using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int brauzers = int.Parse(Console.ReadLine());
            int jobs = int.Parse(Console.ReadLine());
            int totalPrice = 0;

            for (int i = 1; i <= brauzers; i++)
            {
                string brauzersName = Console.ReadLine();
                if (brauzersName == "Facebook")
                {
                    totalPrice += 150;
                }
                else if (brauzersName == "Instagram")
                {
                    totalPrice += 100;
                }

                else if (brauzersName == "Reddit")
                {
                    totalPrice += 50;
                }

            }
            double totalPriceFine = jobs - totalPrice;
            if (totalPriceFine <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {

                Console.WriteLine(totalPriceFine);
            }
        }
    }
}
