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

namespace WeatherApp
{
    [Activity(Label = "Admin_ Login")]
    public class admin_Login : Activity
    {
        Button btnLogin, btnBack;
        EditText txtEmail, txtPassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);

            //create the object of the button
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += new EventHandler(BtnAdminLogin_Clicked);

            //create the object of the button
            btnBack = FindViewById<Button>(Resource.Id.btnBck);
            btnBack.Click += new EventHandler(BtnAdminBack_Clicked);

            txtEmail = FindViewById<EditText>(Resource.Id.edtUser);

            txtPassword = FindViewById<EditText>(Resource.Id.edtpssword);



            // Create your application here
        }

        private void BtnAdminLogin_Clicked(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("admin@gmail.com") && txtPassword.Text.Equals("admin"))
            {

            }
            else {
                Toast.MakeText(Application.Context, "Check User Name  and  Password", ToastLength.Short).Show();
            }

        }

        private void BtnAdminBack_Clicked(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);

        }
    }
}