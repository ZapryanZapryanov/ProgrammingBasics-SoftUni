using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double studentBillet = 0;
            double standartBillet = 0;
            double kidBillet = 0;



            while (command != "Finish")
            {
                int outa = int.Parse(Console.ReadLine());
                double studentB = 0;
                double standartB = 0;
                double kidB = 0;
                for (int i = 0; i < outa; i++)
                {
                    string billets = Console.ReadLine();

                    if (billets == "End")
                    {
                        break;
                    }

                    switch (billets)
                    {
                        case "student":
                            studentB++;
                            break;
                        case "standard":
                            standartB++;
                            break;
                        case "kid":
                            kidB++;
                            break;
                    }
                }
                studentBillet += studentB;
                standartBillet += standartB;
                kidBillet += kidB;
                double all = studentB + standartB + kidB;
                double finaly = all / outa * 100.0;
                Console.WriteLine($"{command} - {finaly:f2}% full.");

                command = Console.ReadLine();
            }
            double totalaa = studentBillet + standartBillet + kidBillet;
            Console.WriteLine($"Total tickets: {totalaa}");
            double finalyStudent = studentBillet / totalaa * 100.0;
            double finalyStandart = standartBillet / totalaa * 100.0;
            double finalyKids = kidBillet / totalaa * 100.0;
            Console.WriteLine($"{finalyStudent:f2}% student tickets.");
            Console.WriteLine($"{finalyStandart:f2}% standard tickets.");
            Console.WriteLine($"{finalyKids:f2}% kids tickets.");
        }
    }
}
