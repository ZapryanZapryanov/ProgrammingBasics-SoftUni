using System;

namespace _03._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            String animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "crocodile":
                case "snake":
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
