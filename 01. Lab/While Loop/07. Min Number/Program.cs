using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numMin = int.MaxValue;

            while (number != "Stop")
            {

                int numbersss = int.Parse(number);

                if (numbersss < numMin)
                {
                    numMin = numbersss;
                }
                number = Console.ReadLine();



            }
            Console.WriteLine(numMin);
        }
    }
}
