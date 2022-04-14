using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocenka = int.Parse(Console.ReadLine());
            string tasks = Console.ReadLine();


            int allTasks = 0;
            string outTaskt = "";
            int won = 0;
            int notOcenki = 0;


            while (tasks != "Enough")
            {
                int ocenki = int.Parse(Console.ReadLine());
                allTasks += ocenki;
                won++;
                outTaskt = tasks;
                tasks = Console.ReadLine();
                if (ocenki <= 4)
                {
                    notOcenki++;
                    if (notOcenki == ocenka)
                    {
                        Console.WriteLine($"You need a break, {ocenka} poor grades.");
                        break;
                    }
                }




            }
            if (tasks == "Enough")
            {
                double final = 1.0 * allTasks / won;
                Console.WriteLine($"Average score: {final:f2}");
                Console.WriteLine($"Number of problems: {won}");
                Console.WriteLine($"Last problem: {outTaskt}");
            }
        }
    }
}
