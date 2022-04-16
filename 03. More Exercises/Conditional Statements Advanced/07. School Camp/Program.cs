using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());

            double price = 0;
            string sport = string.Empty;
            //double discount = 0;

            if (season == "Spring" && group == "girls")
            {
                price = numStudents * numNights * 7.20;
                sport = "Athletics";
            }
            if (season == "Spring" && group == "boys")
            {
                price = numStudents * numNights * 7.20;
                sport = "Tennis";
            }
            if (season == "Spring" && group == "mixed")
            {
                price = numStudents * numNights * 9.50;
                sport = "Cycling";
            }
            if (season == "Winter" && group == "girls")
            {
                price = numStudents * numNights * 9.60;
                sport = "Gymnastics";
            }
            if (season == "Winter" && group == "boys")
            {
                price = numStudents * numNights * 9.60;
                sport = "Judo";
            }
            if (season == "Winter" && group == "mixed")
            {
                price = numStudents * numNights * 10;
                sport = "Ski";
            }
            if (season == "Summer" && group == "girls")
            {
                price = numStudents * numNights * 15;
                sport = "Volleyball";
            }
            if (season == "Summer" && group == "boys")
            {
                price = numStudents * numNights * 15;
                sport = "Football";
            }
            if (season == "Summer" && group == "mixed")
            {
                price = numStudents * numNights * 20;
                sport = "Swimming";
            }

            if (numStudents >= 50)
            {
                price *= 0.50;
            }
            if (numStudents >= 20 && numStudents < 50)
            {
                price *= 0.85;
            }
            if (numStudents >= 10 && numStudents < 20)
            {
                price *= 0.95;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
