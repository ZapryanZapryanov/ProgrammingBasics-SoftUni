using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lenght = text.Length;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
        }
    }
}
