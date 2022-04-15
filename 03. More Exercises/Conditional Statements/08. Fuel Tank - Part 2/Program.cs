using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double price = 0;

            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;

            double discGasoline = gasoline - 0.18;
            double discDiesel = diesel - 0.12;
            double discGas = gas - 0.08;

            if (fuel == "Gas" && card == "Yes")
            {
                price = discGas * amount;
            }
            else if (fuel == "Gas" && card == "No")
            {
                price = gas * amount;
            }

            else if (fuel == "Gasoline" && card == "Yes")
            {
                price = discGasoline * amount;
            }
            else if (fuel == "Gasoline" && card == "No")
            {
                price = gasoline * amount;
            }

            else if (fuel == "Diesel" && card == "Yes")
            {
                price = discDiesel * amount;
            }
            else if (fuel == "Diesel" && card == "No")
            {
                price = diesel * amount;
            }

            if (amount >= 20 && amount <= 25)
            {
                price *= 0.92;
            }
            else if (amount > 25)
            {
                price *= 0.90;
            }
            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
