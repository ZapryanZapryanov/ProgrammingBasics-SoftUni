using System;

namespace _10._Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool flag = num == 0;

            if (!flag)
            {
                if (num < 100 || num > 200)
                {
                    Console.WriteLine("invalid");
                }

            }
        }
    }
}
