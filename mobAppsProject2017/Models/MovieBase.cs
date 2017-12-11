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

            Movies = FakeService.GetMovies();

        }



        public void Add(Movie movie)
        {

            if (!Movies.Contains(movie))

            {

                Movies.Add(movie);

                FakeService.Write(movie);

            }

        }



        public void Delete(Movie movie)

        {

            if (Movies.Contains(movie))

            {

                Movies.Remove(movie);

                FakeService.Delete(movie);

            }

        }



        public void Update(Movie movie)

        {

            FakeService.Write(movie);

        }

    }

}
