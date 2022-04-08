using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());

            int secondNum = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true)
            {
                sum += secondNum;
                if (firstNum <= sum)
                {
                    Console.WriteLine(sum);
                    break;
                }

                secondNum = int.Parse(Console.ReadLine());
            }

        }
    }
}
