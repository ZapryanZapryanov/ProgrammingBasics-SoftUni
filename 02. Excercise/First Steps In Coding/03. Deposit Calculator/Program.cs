using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depositMothers = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double interest = depositAmount * (interestRate / 100.0);
            double interestMothers = interest / 12;
            double total = depositAmount + depositMothers * interestMothers;
            Console.WriteLine(total);
        }
    }
}
