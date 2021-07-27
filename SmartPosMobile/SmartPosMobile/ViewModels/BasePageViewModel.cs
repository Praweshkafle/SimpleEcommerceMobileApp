using SmartPosMobile.Helper;
using SmartPosMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartPosMobile.ViewModels
{
    public class BasePageViewModel : ObservableBase
    {
        public BasePageViewModel()
        {
            Task.Run(() =>
            {
                refreshCount();
                ItemCount = SqlDb.GetAll().Count;
            });
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(nameof(IsBusy)); }
        }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { _isRefreshing = value; OnPropertyChanged(nameof(IsRefreshing)); }
        }

        private long _itemCount;
        public long ItemCount
        {
            get => _itemCount;
            set
            {
                _itemCount = value; OnPropertyChanged(nameof(ItemCount));
            }
        }
        private List<Items> _items = new List<Items>();
        public List<Items> ItemsData
        {
            get => _items;
            set
            {
                _items = value; OnPropertyChanged(nameof(ItemsData));
            }
        }
        private void refreshCount()
        {
            Task.Delay(2000);
            ItemsData.Clear();
            this.ItemCount = SqlDb.GetAll().Count;
        }

    }
}
