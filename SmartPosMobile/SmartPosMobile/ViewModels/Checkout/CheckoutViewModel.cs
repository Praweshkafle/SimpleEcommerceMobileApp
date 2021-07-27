using SmartPosMobile.Helper;
using SmartPosMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartPosMobile.ViewModels.Checkout
{
    public class CheckoutViewModel : BasePageViewModel
    {
        private long _noOfItem;

        public long NoOfItem
        {
            get { return _noOfItem; }
            set { _noOfItem = value; OnPropertyChanged(nameof(NoOfItem)); }
        }

       
        public CheckoutViewModel(List<Items> items)
        {
            //Copy(items);
            Task.Run(() =>
            {
               foreach (var item in items)
               {
               ItemsData.Add(item);
               }
               ItemsData = LoadDbItems();
            });
        }

        private List<Items> LoadDbItems()
        {
            var selectedItems = SqlDb.GetAll();
            return selectedItems;
        }

        //private void Copy(ObservableCollection<Items> items)
        //{
        //    foreach (var item in items)
        //    {
        //        ItemsData.Add(item);
        //    }
        //}

        public ICommand AddItem => new Command<Items>((addedData) =>
             {
                 try
                 {
                     //foreach (var data in ItemCollection)
                     //{
                     //    if (addedData.Id==data.Id)
                     //    {
                     //        addedData.Quantity++;
                     //    }
                     //}
                 }
                 catch (Exception ex)
                 {

                     throw new Exception(ex.Message);
                 }
             });

        public ICommand DeleteItem =>  new Command<Items>((deleteData) =>
             {
                 if (ItemsData.Contains(deleteData))
                 {
                     SqlDb.Delete(deleteData.Id);
                     refresh();
                     refreshCount();
                     ItemsViewModel model = new ItemsViewModel();
                 } 
             });

        public ICommand Proceed => new Command(() =>
         {
             //stuff
         });

        private void refresh()
        {
            Task.Delay(2000);
            ItemsData.Clear();
            ItemsData = SqlDb.GetAll();
        }
        private void refreshCount()
        {
            Task.Delay(2000);
            ItemsData.Clear();
            ItemsData = SqlDb.GetAll();
            ItemCount = ItemsData.Count;
        }

    }
}
