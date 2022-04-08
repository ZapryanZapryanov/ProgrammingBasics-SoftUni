using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numMin = int.MinValue;
            while (number != "Stop")
            {

                int numbersss = int.Parse(number);

                if (numbersss > numMin)
                {
                    numMin = numbersss;
                }
                number = Console.ReadLine();



            }
            Console.WriteLine(numMin);

        }
    }
}
