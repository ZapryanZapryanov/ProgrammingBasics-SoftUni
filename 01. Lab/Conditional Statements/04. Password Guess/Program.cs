using System;

namespace _04._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passrow = Console.ReadLine();
            bool pass = passrow == ("s3cr3t!P@ssw0rd");
            if (pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
