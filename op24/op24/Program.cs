using System;
using System.Collections.Generic;

namespace op24 {
    class Program {
        static void Main(string[] args) {

            //System.Collections.Generic
            //a Movie has a Title, a Genre, a Year and a Rating

            //make a List of Movies with 10 of your favorite movies
            ListOfMovies movies = new ListOfMovies() {
                new Movie(){Title="The Wizard of Oz", Year=1939, Genre="Comedy", Rating=98 },
                new Movie(){Title="Citizen Kane", Year=1949, Genre="Drama", Rating=100 },
                new Movie(){Title="Get Out", Year=2017, Genre="Thriller", Rating=99 },
                new Movie(){Title="Mad Max Fury Road", Year=2015, Genre="Sci Fi", Rating=97 },
                new Movie(){Title="The Third Man", Year=1949, Genre="Drama", Rating= 99},
                new Movie(){Title="Moonlight", Year=2016, Genre="Comedy", Rating=98 },
                new Movie(){Title="Arrival", Year=2016, Genre="Sci Fi", Rating=94 },
                new Movie(){Title="Alien", Year=1979, Genre="Sci Fi", Rating=97 },
                new Movie(){Title="A Smile Like Yours", Year=1997, Genre="Comedy", Rating=6 },
                new Movie(){Title="Hot Pursuit", Year=2015, Genre="Comedy", Rating=7 },
                new Movie(){Title="The Last Airbender", Year=2010, Genre="Sci Fi", Rating=6 },
                new Movie(){Title="Son Of The Pink Panther", Year=1993, Genre="Comedy", Rating=6 },
                new Movie(){Title="Babylon A.D.", Year=2008, Genre="Sci Fi", Rating=6 }
            };
            
            //write a method to print the list
            PrintList(movies);
            //write a method that
            // - accepts a List of Movie as input
            // - returns a new List of Movie containing 
            //   only the movies with a rating higher than 7
            //List<Movie> highRatings = FilterRatingHigherThan70(movies);
            List<Movie> highRatings = movies.FilterRatingHigherThan70();

            PrintList(highRatings);

            //write a method that
            // - accepts a List of Movie as input
            // - returns a new List of Movie containing 
            //   only the movies with a title that begins with an A
            List<Movie> titlesA = movies.FilterTitleStartsWithA();
            PrintList(titlesA);

            //write a method that
            // - accepts a List of Movie as input
            // - returns a new List of Movie containing 
            //   only the movies with a Year equal or lower than 1980
            List<Movie> yearLower1980 = movies.FilterYearLower1980();
            PrintList(yearLower1980);

            List<Movie> comedies = movies.Filter(IsItAComedy);
            PrintList(comedies);

            List<Movie> recentMovies = movies.Filter(isItAfter2000);

            recentMovies = movies.Filter(m => m.Year >= 2000); //lambda expression

            PrintList(recentMovies);

            PrintList(movies.Filter(movie => movie.Title.StartsWith("C")));

            


            Console.ReadLine();
        }

        static void Say(int x) {

        }

        static bool isItAfter2000(Movie movie) {
            return movie.Year >= 2000; 
        }

        static bool IsItAComedy(Movie m) {
            return m.Genre.Contains("Comedy");
        }
        static void PrintList(List<Movie> movies) {
            Console.WriteLine("*****************************");
            for (int i = 0; i < movies.Count; i++) {
                Console.WriteLine($"{i} - {movies[i]}");
            }
        }
    }
}
