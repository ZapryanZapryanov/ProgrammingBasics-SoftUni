using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int heightCm = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double aquarium = lenghtCm * widthCm * heightCm;
            double liteel = aquarium / 1000;
            double housProcent = procent / 100.0;
            double allLitters = liteel * (1 - housProcent);
            Console.WriteLine(allLitters);
        }
    }
}
