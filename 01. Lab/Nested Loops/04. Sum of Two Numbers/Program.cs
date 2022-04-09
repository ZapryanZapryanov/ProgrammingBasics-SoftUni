using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;
            bool flag = false;
            for (int num1 = start; num1 <= stop; num1++)
            {

                for (int num2 = start; num2 <= stop; num2++)
                {
                    number++;
                    sum = num1 + num2;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{number} ({num1} + {num2} = {magicNum})");
                        flag = true;
                        break;
                    }

                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{number} combinations - neither equals {magicNum}");
            }
        }
    }
}
