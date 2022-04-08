using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int finalNum = 1;

            while (finalNum <= n)
            {
                Console.WriteLine(finalNum);
                finalNum = finalNum * 2 + 1;


            }

        }
    }
}
