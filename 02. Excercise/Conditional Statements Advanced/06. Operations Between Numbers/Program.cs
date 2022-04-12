using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            char umnojenie = char.Parse(Console.ReadLine());


            double finaly = 0;
            double start = 0;



            if (umnojenie == '+')
            {
                finaly = first + second;

                if (finaly % 2 == 0)
                {
                    Console.WriteLine($"{first} + {second} = {finaly} - even");
                }
                else
                {
                    Console.WriteLine($"{first} + {second} = {finaly} ");
                }
            }
            else if (umnojenie == '-')
            {
                finaly = first - second;

                if (finaly % 2 == 0)
                {
                    Console.WriteLine($"{first} - {second} = {finaly}");
                }
                else
                {
                    Console.WriteLine($"{first} - {second} = {finaly} - odd");
                }
            }
            else if (umnojenie == '*')
            {
                finaly = first * second;

                if (finaly % 2 == 0)
                {
                    Console.WriteLine($"{first} * {second} = {finaly}");
                }
                else
                {
                    Console.WriteLine($"{first} * {second} = {finaly} - odd");
                }
            }
            else if (umnojenie == '/' && second != 0)
            {
                start = first / second;

                Console.WriteLine($"{first} / {second} = {start:f2}");
            }
            else if (umnojenie == '%' && second != 0)
            {
                start = first % second;

                Console.WriteLine($"{first} % {second} = {start}");
            }
            else
            {
                Console.WriteLine($"Cannot divide {first} by zero");
            }
        }
    }
}
