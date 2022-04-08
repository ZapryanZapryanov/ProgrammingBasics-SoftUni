using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double final = 0;
            double evaluation = 1;
            double torn = 0;


            while (evaluation <= 12)
            {
                double currEvaluation = double.Parse(Console.ReadLine());


                if (currEvaluation < 4)
                {
                    torn++;

                    if (torn == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {evaluation} grade");
                        break;
                    }
                    continue;
                }



                evaluation++;
                final += currEvaluation;

            }
            double all = final / 12;
            if (torn < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {all:f2}");
            }

        }
    }
}
