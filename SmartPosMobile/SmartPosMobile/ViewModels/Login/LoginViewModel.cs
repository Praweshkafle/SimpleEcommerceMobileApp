using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Input;
using SmartPosMobile.Helper;
using Xamarin.Forms;
using SmartPosMobile.Models;
using SQLite;
using System.Linq;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace SmartPosMobile.ViewModels.LoginViewModel
{
    public class LoginViewModel : BasePageViewModel
    {
        private readonly ApiRequestCollection _ApiRequestCollection;
        public LoginViewModel()
        {
            _ApiRequestCollection = new ApiRequestCollection();
            postData = new Command(LoginInfo);
        }
        private string _userName;
        public string userName
        {
            get { return _userName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Username Cannot be null");
                }
                _userName = value; OnPropertyChanged(nameof(userName));
            }
        }
        private string _password;
        
        public string password 
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Password Cannot be null");
                }
                _password = value; OnPropertyChanged(nameof(password));
            }
        }

        public Command postData { get; }
        private void LoginInfo()
        {
            Login model = new Login
            {
                Password = password,
                UserName = userName
            };
            _ApiRequestCollection.loginAndGetResponse(model);
        }
    }
}
