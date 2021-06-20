using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Android.Widget.Button btnLogin, btnWeather,btn_Map;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnLogin = FindViewById<Button>(Resource.Id.btnAdminLogin);
            btnLogin.Click += new EventHandler(BtnLogin_Clicked);

            btnWeather = FindViewById<Button>(Resource.Id.btnweather);
            btnWeather.Click += new EventHandler(btn_weather_Clicked);

            btn_Map = FindViewById<Button>(Resource.Id.btnMap);
            btn_Map.Click += new EventHandler(btn_map_Clicked);

        }

        private void btn_map_Clicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(weatherTask));
            StartActivity(intent);
        }

        private void btn_weather_Clicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(webView));
            StartActivity(intent);

        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(admin_Login));
            StartActivity(intent);

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}