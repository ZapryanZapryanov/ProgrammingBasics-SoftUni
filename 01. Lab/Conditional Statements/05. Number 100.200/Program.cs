using System;

namespace _05._Number_100._200
{
    class Program
    {
        static void Main(string[] args)
        {
            int chek = int.Parse(Console.ReadLine());
            bool chekDown = chek < 100;


            bool chekGo = chek > 200;
            if (chekDown)
            {
                Console.WriteLine("Less than 100");
            }
            else if (chekGo)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
