using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Essentials;
using Plugin.MapsPlugin;

namespace WeatherApp
{
    [Activity(Label = "weatherTask")]
    public class weatherTask : Activity
    {
        Button btnLogin, btnBack;
        EditText txtPin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.weather);



            //create the object of the button
            btnLogin = FindViewById<Button>(Resource.Id.btnSearch);
            btnLogin.Click += new EventHandler(btnSearch_Clicked);

            //create the object of the button
            btnBack = FindViewById<Button>(Resource.Id.btnBck);
            btnBack.Click += new EventHandler(BtnAdminBack_Clicked);

            
            txtPin = FindViewById<EditText>(Resource.Id.edtpin);



            // Create your application here
        }

        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            //      Map.OpenAsync(11.26, 75.78, new MapLaunchOptions { NavigationMode = NavigationMode.Driving });
            //var uri = new Uri("http://maps.google.com/maps?saddr=Google+Inc,+8th+Avenue,+New+York,+NY&daddr=John+F.+Kennedy+International+Airport,+Van+Wyck+Expressway,+Jamaica,+New+York&directionsmode=transit");
            CrossMapsPlugin.Current.PinTo("Auckland", 10.7653, 79.0687, 8);
        }

        private void BtnAdminBack_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();

        }

      /*  private async Task btnSearch_ClickedAsync(object sender, EventArgs e)
        {
            int pin =Convert.ToInt32(txtPin.Text.ToString());
            WeatherDetails weather = await GetWeather(txtPin.Text.ToString());
            if (weather != null)
            {
               /* txtLocation.Text = weather.Title;
                txtTemperature.Text = weather.Temperature;
                txtWind.Text = weather.Wind;
                txtHumidity.Text = weather.Humidity;
                txtSunrise.Text = weather.Sunrise;
                txtSunset.Text = weather.Sunset;
                btnGetWeather.Text = "Search Again";*/
      /*
            }

        }*/


    }
}