using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

using System.Collections.ObjectModel;

using Models;



namespace ViewModels

{

    public class MovieBaseViewModel : NotificationBase

    {

        MovieBase movieBase;



        public MovieBaseViewModel(String name)

        {

            movieBase = new MovieBase(name);

            _SelectedIndex = -1;

            // Load the database

            foreach (var movie in movieBase.Movies)

            {

                var np = new MovieViewModel(movie);

                np.PropertyChanged += Movie_OnNotifyPropertyChanged;

                _Movies.Add(np);

            }

        }



        ObservableCollection<MovieViewModel> _Movies

           = new ObservableCollection<MovieViewModel>();

        public ObservableCollection<MovieViewModel> Movies

        {

            get { return _Movies; }

            set { SetProperty(ref _Movies, value); }

        }



        String _Name;

        public String Name

        {

            get { return movieBase.Name; }

        }



        int _SelectedIndex;

        public int SelectedIndex

        {

            get { return _SelectedIndex; }

            set
            {
                if (SetProperty(ref _SelectedIndex, value))

                { RaisePropertyChanged(nameof(SelectedMovie)); }
            }

        }



        public MovieViewModel SelectedMovie

        {

            get { return (_SelectedIndex >= 0) ? _Movies[_SelectedIndex] : null; }

        }



        public void Add()

        {

            var movie = new MovieViewModel();

            movie.PropertyChanged += Movie_OnNotifyPropertyChanged;

            Movies.Add(movie);

            movieBase.Add(movie);

            SelectedIndex = Movies.IndexOf(movie);

        }



        public void Delete()

        {

            if (SelectedIndex != -1)

            {

                var movie = Movies[SelectedIndex];

                Movies.RemoveAt(SelectedIndex);

                movieBase.Delete(movie);

            }

        }



        void Movie_OnNotifyPropertyChanged(Object sender, PropertyChangedEventArgs e)

        {

            movieBase.Update((MovieViewModel)sender);

        }

    }

}
