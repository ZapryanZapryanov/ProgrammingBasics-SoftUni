using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int scale = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double water = pipe1 * hours + pipe2 * hours;

            if (water <= scale)
            {
                Console.WriteLine($"The pool is {(water / scale * 100):f2}% full. " +
                $"Pipe 1: {(pipe1 * hours / water * 100):f2}%. Pipe 2: {(pipe2 * hours / water * 100):f2}%.");

            }
            else
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {water - scale:f2} liters.");
            }
        }
    }
}
