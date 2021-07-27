using Newtonsoft.Json;
using SmartPosMobile.Models;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Net.Http.Headers;

namespace SmartPosMobile.Helper
{
    public class ApiHelper
    {
        static readonly HttpClient client = new HttpClient();
        public static async  Task<ApiResponse> saveData<T>(string uri, T model)
        {
            string url = $"https://pos.surpass.com.np/api"+uri;
            var response = await client.PostAsJsonAsync(url, model);

            if (response.IsSuccessStatusCode)
            {
                return new ApiResponse { Response = await response.Content.ReadAsStringAsync() };
            }
            else
                return new ApiResponse { ErrorMessage = response.ReasonPhrase };
            
        }
        public static async Task<ApiResponse> Get(string url)
        {
            var data = GetUserDetails();
            using (client)
            {
                if (!string.IsNullOrWhiteSpace(data.token))
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Authentication", data.token);

                var request = await client.GetAsync(url);
                if (request.IsSuccessStatusCode)
                {
                    return new ApiResponse { Response = await request.Content.ReadAsStringAsync() };
                }
                else
                    return new ApiResponse { ErrorMessage = request.ReasonPhrase };
            }
        }
       

        public static async Task<ApiResponse> GetAll()
        {
            var url = "https://pos.surpass.com.np/api/customer";
            var data = GetUserDetails();
            using (client)
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + data.token);
                var request = await client.GetAsync(url);
                Console.WriteLine();
                if (request.IsSuccessStatusCode)
                {
                    return new ApiResponse { Response = await request.Content.ReadAsStringAsync() };
                }
                else
                    return new ApiResponse { ErrorMessage = request.ReasonPhrase };
            }
        }
        public static User GetUserDetails()
        {
            return JsonConvert.DeserializeObject<User>(Preferences.Get("user_details", string.Empty));
        }
    }
    public class ApiResponse
    {
        public bool Successful => ErrorMessage == null;
        public string ErrorMessage { get; set; }
        public string Response { get; set; }
    }
    
}

