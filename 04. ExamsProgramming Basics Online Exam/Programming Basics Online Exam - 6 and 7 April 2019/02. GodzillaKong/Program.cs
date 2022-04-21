using System;

namespace _02._GodzillaKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgeFilm = double.Parse(Console.ReadLine());
            int numberStatist = int.Parse(Console.ReadLine());
            double clothWonStatist = double.Parse(Console.ReadLine());
            double dekor = budgeFilm * 0.10;
            double sumCloth = numberStatist * clothWonStatist;
            if (numberStatist > 150)
            {
                sumCloth -= 0.10 * sumCloth;

            }
            double action = dekor + sumCloth;
            if (action <= budgeFilm)
            {
                double finaly = budgeFilm - action;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {finaly:f2} leva left.");

            }
            else
            {
                double finaly1 = Math.Abs(action - budgeFilm);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finaly1:f2} leva more.");
            }
        }
    }
}
