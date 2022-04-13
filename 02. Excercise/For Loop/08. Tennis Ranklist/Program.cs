using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTornaments = int.Parse(Console.ReadLine());
            int numToken = int.Parse(Console.ReadLine());
            int token = 0;
            int final = 0;


            for (int i = 0; i < numTornaments; i++)
            {
                string etap = Console.ReadLine();
                if (etap == "F")
                {
                    token += 1200;
                }
                else if (etap == "W")
                {
                    token += 2000;
                    final++;
                }
                else if (etap == "SF")
                {
                    token += 720;
                }
            }

            double price = token / numTornaments;
            double winTornaments = (double)final / numTornaments * 100;
            double all = token + numToken;
            Console.WriteLine($"Final points: {all}");
            Console.WriteLine($"Average points: {Math.Ceiling(price)}");
            Console.WriteLine($"{winTornaments:f2}%");
        }
    }
}
