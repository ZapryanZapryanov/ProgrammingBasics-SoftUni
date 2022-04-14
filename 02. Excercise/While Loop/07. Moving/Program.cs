using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int windt = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string box = Console.ReadLine();
            int all = windt * lenght * height;
            int numberAll = 0;


            while (box != "Done")
            {
                int numBox = int.Parse(box);
                all -= numBox;
                if (all < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(all)} Cubic meters more.");
                    break;
                }

                box = Console.ReadLine();
            }
            if (box == "Done")
            {
                Console.WriteLine($"{all} Cubic meters left.");
            }
        }
    }
}
