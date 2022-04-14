using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFilms = Console.ReadLine();

            double totalStudents = 0;
            double totalKids = 0;
            double totalStandart = 0;
            double stikers = 0;
            while (nameFilms != "Finish")
            {
                int mesta = int.Parse(Console.ReadLine());
                int students = 0;
                int kids = 0;
                int standart = 0;
                for (int i = 1; i <= mesta; i++)
                {
                    string comannd = Console.ReadLine();
                    if (comannd == "End")
                    {
                        break;
                    }
                    switch (comannd)
                    {
                        case "student":
                            students++;
                            break;
                        case "kid":
                            kids++;
                            break;
                        case "standard":
                            standart++;
                            break;
                    }
                }
                totalStudents += students;
                totalKids += kids;
                totalStandart += standart;
                double all = (standart + students + kids) / (double)mesta * 100;
                Console.WriteLine($"{nameFilms} - {all:f2}% full.");
                nameFilms = Console.ReadLine();

            }
            stikers = totalKids + totalStandart + totalStudents;
            double finishStudents = totalStudents / stikers * 100;
            double finishKids = totalKids / stikers * 100;
            double finishStandart = totalStandart / stikers * 100;
            Console.WriteLine($"Total tickets: {stikers}");
            Console.WriteLine($"{finishStudents:f2}% student tickets.");
            Console.WriteLine($"{finishStandart:f2}% standard tickets.");
            Console.WriteLine($"{finishKids:f2}% kids tickets.");

        }
    }
}
