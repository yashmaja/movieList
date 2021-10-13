using System;

namespace movieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            MovieLibrary bestMovies = new MovieLibrary();
            Console.WriteLine($"\nThere are {bestMovies.CountMovies()} movies in this list.");
            bool repeat = true;

            while (repeat)
            {
                bestMovies.DisplayMovies(bestMovies.GetCategory());

                repeat = Validator.Validator.Repeat("Would you like to enter another category?");
            }
        }
    }
}
