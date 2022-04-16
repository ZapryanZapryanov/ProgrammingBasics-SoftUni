using System;

namespace _08._Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {

            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            bool first = ((x == x1 || x == x2) && (y >= y1) && (y <= y2));
            bool second = ((y == y1 || y == y2) && (x >= x1) && (x <= x2));

            if (first || second)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
