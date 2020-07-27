using System;
using System.Collections.Generic;

namespace MovieList
{
    class Movie //constructor
    {
        private string Title; //property
        private string Category; //property

        public string Name
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }

        public string Cat
        {
            get
            {
                return Category;
            }
            set
            {
                Category = value;
            }
        }

        public Movie(string movieTitle, string movieCat) //initialization
        {
            Title = movieTitle;
            Category = movieCat;
        }


    class Program
    {
        static void Main(string[] args)
        {
                bool keepLooping = true;


                List<Movie> movieList = new List<Movie>(); //Instantiating a list of movies
                //Movie newMovie = new Movie("Title", "Category");
                movieList.Add(new Movie("Dark City", "Sci Fi"));
                movieList.Add(new Movie("The Big Lebowski", "Comedy"));
                movieList.Add(new Movie("The Usual Suspects", "Thriller"));
                movieList.Add(new Movie("Primer", "Sci Fi"));
                movieList.Add(new Movie("Inception", "Sci Fi"));
                movieList.Add(new Movie("The Darjeeling Limited", "Comedy"));
                movieList.Add(new Movie("The Life Aquatic with Steve Zissou", "Comedy"));
                movieList.Add(new Movie("Rushmore", "Comedy"));
                movieList.Add(new Movie("Interstellar", "Sci Fi"));
                movieList.Add(new Movie("The Hitchhiker's Guide to the Galaxy", "Sci Fi"));
                movieList.Add(new Movie("The Jacket", "Thriller"));
                movieList.Add(new Movie("Idiocracy", "Documentary"));
                movieList.Add(new Movie("Stranger than Fiction", "Fantasy"));
                movieList.Add(new Movie("Eternal Sunshine of the Spotless Mind", "Sci Fi"));
                movieList.Add(new Movie("Funny Games", "Thriller"));
                movieList.Add(new Movie("The Science of Sleep", "Fantasy"));

                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine();
                Console.WriteLine($"There are {movieList.Count} movies in this list.");

                while (keepLooping)
                {
                    bool catCheck = false;
                    Console.Write($"What category are you interested in? "); //Ask for user input
                    string userInput = Console.ReadLine();
                    Console.WriteLine();

                    foreach (Movie title in movieList) //iterate though list
                    {
                        if (title.Cat == userInput) //Check if category exists in list
                        {
                            catCheck = true;
                            break;
                        }

                    }
                    if (catCheck)
                    {
                        foreach (Movie title in movieList) //iterate though list
                        {
                            if (title.Cat == userInput) //Check if category exists in list
                            {
                                Console.WriteLine(title.Name, title.Cat);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, no movies exist in {userInput}.");
                    }

                    Console.WriteLine();
                    Console.Write("Continue? (y/n)?  ");
                    string userCont = Console.ReadLine();
                    string cont = userCont.ToLower();
                    if (cont == "n")
                    {
                        keepLooping = false;
                    }
                    else if (cont == "y")
                    {
                        keepLooping = true;
                    }else
                    {
                        Console.WriteLine("You did not select y or n, continuing.");
                        keepLooping = true;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
