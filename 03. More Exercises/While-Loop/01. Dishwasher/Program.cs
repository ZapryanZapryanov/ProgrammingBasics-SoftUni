using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergent = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int dishes = 0;
            int sumDetergent = detergent * 750;

            int plates = 0;
            int pots = 0;
            int count = 0;

            while (command != "End")
            {
                dishes = int.Parse(command);
                count++;
                if (count % 3 == 0)
                {
                    pots += dishes;
                    dishes *= 15;
                    sumDetergent -= dishes;

                }
                if (count != 3 && count != 6 && count != 9)
                {
                    plates += dishes;
                    dishes *= 5;
                    sumDetergent -= dishes;
                }

                if (sumDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(sumDetergent)} ml. more necessary!");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
            Console.WriteLine($"Leftover detergent {sumDetergent} ml.");
        }
    }
}
