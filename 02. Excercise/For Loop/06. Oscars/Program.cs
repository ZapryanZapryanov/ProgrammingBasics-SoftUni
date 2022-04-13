using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double token = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());
            double sum = token;

            bool found = false;


            for (int i = 0; i < evaluators; i++)
            {
                string nameEvaluators = Console.ReadLine();
                double evaluatorsToken = double.Parse(Console.ReadLine());
                double points = (nameEvaluators.Length * evaluatorsToken) / 2;
                sum += points;
                if (sum >= 1250.5)
                {
                    found = true;
                    break;
                }

            }
            if (found)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - sum:f1} more!");
            }

        }
    }
}
