using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Data;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace mobileApps2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page

    {

        public MainPage()
        {

            this.InitializeComponent();
            makeFile();
            //readFile();

            MovieBase = new MovieBaseViewModel("MovieTable");

        }

        public MovieBaseViewModel MovieBase { get; set; }

        private async void makeFile()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile playlists = await storageFolder.CreateFileAsync("movies.txt", CreationCollisionOption.OpenIfExists);
        }

    }
}
