using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPosMobile.SQLiteHelper
{
   public class ItemDb
    {
        [PrimaryKey]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Specification { get; set; }
        public string Image { get; set; }
    }
}
