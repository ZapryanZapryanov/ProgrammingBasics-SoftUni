using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int numberDay = int.Parse(Console.ReadLine());

            int hoursBook = numberPages / pages;
            int hoursDay = hoursBook / numberDay;
            Console.WriteLine(hoursDay);
        }
    }
}
