using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieList
{
    class MovieLibrary
    {
        public List<Movie> Library;
        public List<string> Categories;

        //constructor

        public MovieLibrary()
        {
            Categories = new List<string> { "Comedy", "Drama", "SciFi", "Classic", "Animated" };

            Library = new List<Movie>
            {
                new Movie("Modern Times", "Comedy"),
                new Movie("White Chicks", "Comedy"),
                new Movie("The Princess Bride", "Comedy"),
                new Movie("2001: A Space Odyssey", "SciFi"),
                new Movie("The Godfather", "Classic"),
                new Movie("Citizen Kane", "Classic"),
                new Movie("Singin' in the Rain", "Classic"),
                new Movie("Star Wars", "SciFi"),
                new Movie("Alien", "SciFi"),
                new Movie("Pulp Fiction", "Classic"),
                new Movie("The Truman Show", "Drama"),
                new Movie("Spirited Away", "Animated"),
                new Movie("Howl's Moving Castle", "Animated"),
                new Movie("My Neighbor Totoro", "Animated"),
                new Movie("Brokeback Mountain", "Drama"),
                new Movie("The Shining", "Horror"),
                new Movie("Some Like It Hot", "Comedy"),
                new Movie("Nightmare Before Christmas", "Animated"),
                new Movie("Metropolis", "SciFi"),
                new Movie("Sound of Music", "Musical"),
                new Movie("Phantom of the Opera", "Musical"),
                new Movie("Fiddler on the Roof", "Musical"),
                new Movie("The King and I", "Musical"),
                new Movie("West Side Story", "Musical"),
                new Movie("Annie", "Musical"),
                new Movie("Streetcar Named Desire", "Classic"),
                new Movie("Princess and the Frog", "Animated"),
                new Movie("Up", "Animated"),
                new Movie("Interstellar", "SciFi"),
                new Movie("Alien", "SciFi"),
                new Movie("The Shawshank Redemption", "Animated"),
                new Movie("Fantasia", "Classic"),
                new Movie("Beauty and the Beast", "Animated"),
                new Movie("The Great Gatsby", "Drama"),
                new Movie("Ratatouille", "Animation"),
                new Movie("WALL-E", "Animated"),
                new Movie("The Wizard of Oz", "Classic"),
                new Movie("The Breakfast Club", "Classic"),
                new Movie("Ferris Bueller's Day Off", "Comedy"),
                new Movie("Parasite", "Drama"),
                new Movie("Titanic", "Drama"),
                new Movie("Rocky", "Drama"),
                new Movie("Monty Python and the Holy Grail", "Comedy"),
                new Movie("Napolean Dynamite", "Comedy"),
                new Movie("Dead Poets Society", "Drama"),
                new Movie("The Birdcage", "Comedy"),
                new Movie("Jurrassic Park", "SciFi"),
                new Movie("Grease", "Musical"),
                new Movie("Forrest Gump", "Drama"),
                new Movie("Back tot he Future", "SciFi"),
                new Movie("The Rocky Horror Picture Show", "Musical"),
            };
        }

        //methods

        public void DisplayMovies(int categoryNum)
        {
            string categoryChoice = Categories[categoryNum - 1];

            List<Movie> movieChoices = Library.FindAll(movie => movie.Category == categoryChoice).ToList();
            
            /*
            List<Movie> sortedMovies = new List<Movie>();

            //int i = 1;
            int sortNum;

            foreach (Movie movie in movieChoices)
            {
                for(int i = 0; i < movieChoices.Count(); i++)
                { 
                    sortNum = movie.Name.CompareTo(movieChoices[i].Name);
                    if (sortNum > 0)
                    {

                    }

            }
            */

            Console.WriteLine($"\nBest All Time {movieChoices[1].Category} Movies");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            movieChoices.ForEach(movie => Console.WriteLine(movie.Name));
        }

        public int CountMovies()
        {
            return Library.Count();
        }

        public int GetCategory()
        {
            Console.Write("\nWhich category are you interested in?" +
                "\n1. Comedy" +
                "\n2. Drama" +
                "\n3. SciFi" +
                "\n4. Classic" +
                "\n5. Animated" +
                "\nEnter a number 1-5: ");
            
            return Validator.Validator.GetInt(1, 5);
        }
    }
}