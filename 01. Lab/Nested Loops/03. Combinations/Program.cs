using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i <= n; i++)
            {

                for (int j = 0; j <= n; j++)
                {
                    for (int a = 0; a <= n; a++)
                    {
                        if (i + j + a == n)
                        {
                            k++;


                        }
                    }
                }
            }
            Console.WriteLine(k);
        }
    }
}
