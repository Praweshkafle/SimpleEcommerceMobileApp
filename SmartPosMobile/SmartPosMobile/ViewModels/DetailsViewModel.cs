using SmartPosMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPosMobile.ViewModels
{
    public class DetailsViewModel: BasePageViewModel
    {
        private Items item;
        public string category { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        private long id { get; set; }
        public string price { get; set; }
        public string specification { get; set; }
        public string title { get; set; }

        public long Ids
        {
            get => id;
            set
            {
                id = value; OnPropertyChanged(nameof(Ids));
            }
        }
        public DetailsViewModel(Items items )
        {
            item = items;
            category = item.Category;
            description = item.Description;
            image = item.Image;
            Ids = item.Id;
            price = item.Price;
            specification = item.Specification;
            title = item.Title;
        }
    }
}
