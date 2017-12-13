using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;



namespace ViewModels

{

    public class MovieViewModel : NotificationBase<Movie>

    {

        public MovieViewModel(Movie movie = null) : base(movie) { }

        public String Title

        {

            get { return This.Title; }

            set { SetProperty(This.Title, value, () => This.Title = value); }

        }

        public int Year

        {

            get { return This.Year; }

            set { SetProperty(This.Year, value, () => This.Year = value); }

        }

    }

}
