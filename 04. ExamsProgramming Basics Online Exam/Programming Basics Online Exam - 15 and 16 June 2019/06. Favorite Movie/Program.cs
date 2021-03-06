using System;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int bestMovieScore = int.MinValue;
            string bestMovie = string.Empty;
            int count = 0;
            while (movie != "STOP")
            {
                count++;

                int totalP = 0;

                foreach (var letter in movie)
                {
                    if (char.IsLower(letter))
                    {
                        totalP += (int)letter - movie.Length * 2;
                    }
                    else if (char.IsUpper(letter))
                    {
                        totalP += (int)letter - movie.Length;
                    }
                    else
                    {
                        totalP += (int)letter;
                    }
                }

                int totalPoints = totalP;

                if (totalPoints > bestMovieScore)
                {
                    bestMovieScore = totalPoints;
                    bestMovie = movie;
                }
                if (count == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                movie = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {bestMovieScore} ASCII sum.");
        }
    }
}
