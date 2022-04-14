using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int allSteps = 0;
            while (steps != "Going home")
            {
                int stepsNum = int.Parse(steps);
                allSteps += stepsNum;
                if (allSteps > 10000)
                {
                    double all = allSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{all} steps over the goal!");
                    return;
                }



                steps = Console.ReadLine();
            }
            int stepsOne = int.Parse(Console.ReadLine());
            allSteps += stepsOne;
            if (allSteps > 10000)
            {
                int aaa = allSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{aaa} steps over the goal!");
            }
            else
            {
                int not = 10000 - allSteps;
                Console.WriteLine($"{not} more steps to reach goal.");
            }
        }
    }
}
