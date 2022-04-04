using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int numProject = num * 3;

            Console.WriteLine($"The architect {firstName} will need {numProject} hours to complete {num} project/s.");
        }
    }
}
