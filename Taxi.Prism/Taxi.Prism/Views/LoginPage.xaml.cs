//using Plugin.Geolocator;
//using Plugin.Geolocator.Abstractions;
//using System;
using Xamarin.Forms;

namespace Taxi.Prism.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //InitialitacionPlugin();
        }

        //private async void InitialitacionPlugin()
        //{
        //    if (!CrossGeolocator.IsSupported)
        //    {
        //        await DisplayAlert("error", "error al cargar plugin", "OK");
        //        return;
        //    }
        //    if (!CrossGeolocator.Current.IsListening || !CrossGeolocator.Current.IsGeolocationEnabled || !CrossGeolocator.Current.IsGeolocationAvailable)
        //    {
        //        await DisplayAlert("advertencia", "revice su cel gps", "OK");
        //        return;
        //    }

        //    CrossGeolocator.Current.PositionChanged += Current_PositionChanged;
        //    await CrossGeolocator.Current.StartListeningAsync(new TimeSpan(0,0,1), 0.5);
        //}

        //private void Current_PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        //{
        //    if (!CrossGeolocator.Current.IsListening)
        //    {
             
        //        return;
        //    }
        //    var position = CrossGeolocator.Current.GetPositionAsync();

        //    lat.Text = position.Result.Latitude.ToString();
        //    lon.Text = position.Result.Longitude.ToString();
        //}
    }
}
