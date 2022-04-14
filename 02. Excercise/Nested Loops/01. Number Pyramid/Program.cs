using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int currNum = 1;
            bool isEqual = false;
            while (!isEqual)
            {
                for (int a = 1; a <= row; a++)
                {
                    Console.Write($"{currNum} ");
                    currNum++;
                    if (currNum > n)
                    {
                        isEqual = true;
                        break;
                    }
                }
                Console.WriteLine();
                row++;
            }

        }
    }
}
