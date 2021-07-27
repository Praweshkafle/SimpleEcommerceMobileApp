using SmartPosMobile.Helper;
using SmartPosMobile.Models;
using SmartPosMobile.ViewModels.Checkout;
using SmartPosMobile.Views;
using SmartPosMobile.Views.CheckOut;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace SmartPosMobile.ViewModels
{
    public class ItemsViewModel:BasePageViewModel
    {
        public Items data;
        public ObservableCollection<Items> items { get; set; }
        public ItemsViewModel()
        {
            refreshCount();
            data = new Items();
            items = new ObservableCollection<Items>();
            items.Add(new Items
            {
                Id = 1,
                Title = "Machine",
                Category = "machine",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = "20000",
                Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "icon.png",
            });
            items.Add(new Items
            {
                Id = 2,
                Title = "Machine",
                Category = "machine",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = "20000",
                Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Image = "bag.png"
            });
            items.Add(new Items
            {
                Id = 3,
                Title = "Machine",
                Category = "machine",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = "20000",
                Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Awesome Awesome Awesome",
                Image = "burger.jpg"
            });
            items.Add(new Items
            {
                Id = 4,
                Title = "Machine",
                Category = "machine",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = "20000",
                Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Awesome Awesome Awesome",
                Image = "icon.png"
            });
            items.Add(new Items
            {
                Id = 5,
                Title = "Machine",
                Category = "machine",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = "20000",
                Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Awesome Awesome Awesome",
                Image = "bag.png"
            });
            items.Add(new Items
            {
                Id = 6,
                Title = "Machine",
                Category = "machine",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Price = "20000",
                Specification = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Awesome Awesome Awesome",
                Image = "burger.jpg"
            });
            ScrollCheck();
        }

        private void ScrollCheck()
        {
            if (items.Count<=0)
            {
                IsEnable = false;
            }
        }
      
        private bool _isEnable = true;

        public bool IsEnable
        {
            get => _isEnable;
            set
            {
                _isEnable = value; OnPropertyChanged(nameof(IsEnable));
            }
        }
        public ICommand Cart_click => new Command(async () =>
        {
            await NavigationHelper.PushAsync(new CartCheckout()

                {BindingContext = new CheckoutViewModel(ItemsData)}
            );
        });

        public ICommand TapCommand => new Command<Items>(async (selectedItem) =>
        {
            try
            {
                IsEnable = false;
                IsRefreshing = true;
                if ( selectedItem== null)
                    return;
                await NavigationHelper.PushAsync(new ItemsDetails(selectedItem));
            }
            catch { }
            finally
            {
                IsRefreshing = false;
                IsEnable = true;
            }
          
        });
        public ICommand AddToCart => new Command<Items>((item) =>
        {
           
            var data = item;
            SqlDb.Insert(data);
            refreshCount();
        });
        private void refreshCount()
        {
            Task.Delay(2000);
            ItemsData.Clear();
            this.ItemCount = SqlDb.GetAll().Count;
        }
    }
}
