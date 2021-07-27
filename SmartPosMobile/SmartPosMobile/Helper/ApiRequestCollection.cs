using Newtonsoft.Json;
using SmartPosMobile.Models;
using SmartPosMobile.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Essentials;

namespace SmartPosMobile.Helper
{
   public class ApiRequestCollection
    {
        public ApiRequestCollection()
        {
        }
        public async void loginAndGetResponse<T>(T model)
        {
            string uri = "/account/login";
            var data = await ApiHelper.saveData(uri, model);
            if (data.Successful)
            {
                try
                {
                    Preferences.Set("user_details", data.Response);
                    //view model...
                    var userDetails = JsonConvert.DeserializeObject<User>(Preferences.Get("user_details", string.Empty));
                    App.Current.MainPage = new AppShell();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
