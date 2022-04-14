using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int bookCuality = 0;
            string books = Console.ReadLine();
            while (books != "No More Books")
            {

                if (book == books)
                {
                    Console.WriteLine($"You checked {bookCuality} books and found it.");
                    break;
                }
                bookCuality++;
                books = Console.ReadLine();

            }
            if (books == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCuality} books.");
            }
        }
    }
}
