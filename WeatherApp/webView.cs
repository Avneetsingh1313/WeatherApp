using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp
{
    [Activity(Label = "webView")]
    public class webView : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.WebviewLayout);

            WebView Lwebview = FindViewById<WebView>(Resource.Id.webView1);
            Lwebview.SetWebViewClient(new WebViewClient()); // stops request going to Web Browser
            Lwebview.Settings.LoadWithOverviewMode = true;
            Lwebview.Settings.UseWideViewPort = true;
            Lwebview.LoadUrl("https://www.accuweather.com/en/nz/auckland/252066/weather-forecast/252066");


            // Create your application here
        }
    }
}