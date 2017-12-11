using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;



namespace Data

{

    public class Movie

    {

        public String Title { get; set; }

        public int Year { get; set; }

    }



    public class FakeService

    {

        public static String Title = "Fake Data Service.";



        public static List<Movie> GetMovies()

        {

            Debug.WriteLine("GET for people.");

            return new List<Movie>()

                {

                    new Movie() { Title="Blade Runner", Year=1982 }

                };

        }



        public static void Write(Movie movie)

        {

            Debug.WriteLine("INSERT person with name " + movie.Title);

        }



        public static void Delete(Movie movie)

        {

            Debug.WriteLine("DELETE person with name " + movie.Title);

        }

    }

}
