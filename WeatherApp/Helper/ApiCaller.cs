using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Helper
{
    public class ApiCaller
    {
       /* public static async Task<ApiResponse> Get(string url, string authID = null)
        {
            using (var client = new HttpClient())
            {
                if (!string.IsNullOrWhiteSpace(authID))
                {

                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Authorizaation", authID);

                    var request = await client.GetAsync(url);

                    if (request.IsSuccessStatusCode)
                    {
                        return new ApiResponse { Response = await request.Content.ReadAsStringAsync() };
                    }
                    else
                    {
                        return new ApiResponse { ErrorMessage = request.ReasonPhrase };
                    }

                }
            }
        }*/
    }

    public class ApiResponse {
        public bool Sucessful => ErrorMessage == null;
        public string ErrorMessage { get; set; }
        public string Response { get; set; }

    }
}