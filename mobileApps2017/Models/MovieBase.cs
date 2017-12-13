using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;



namespace Models

{

    public class MovieBase

    {

        public List<Movie> Movies { get; set; }

        public String Name { get; set; }



        public MovieBase(String databaseName)

        {

            Name = databaseName;

            Movies = DataService.GetMovies();

        }



        public void Add(Movie movie)
        {

            if (!Movies.Contains(movie))

            {

                Movies.Add(movie);

                DataService.Write(movie);

            }

        }



        public void Delete(Movie movie)

        {

            if (Movies.Contains(movie))

            {

                Movies.Remove(movie);

                DataService.Delete(movie);

            }

        }



        public void Update(Movie movie)

        {

            DataService.Write(movie);

        }

    }

}
