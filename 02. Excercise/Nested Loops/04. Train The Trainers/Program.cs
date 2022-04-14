using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJurry = int.Parse(Console.ReadLine());
            string pressentation = Console.ReadLine();
            double totalGreed = 0;
            int count = 0;

            while (pressentation != "Finish")
            {
                double oneGreed = 0;
                for (int i = 1; i <= numberJurry; i++)
                {
                    double greed = double.Parse(Console.ReadLine());
                    oneGreed += greed;
                    count++;
                    totalGreed += greed;
                }
                Console.WriteLine($"{pressentation} - {oneGreed / numberJurry:f2}.");

                pressentation = Console.ReadLine();
            }
            double finishGreedYears = totalGreed / count;
            Console.WriteLine($"Student's final assessment is {finishGreedYears:f2}.");
        }
    }
}
