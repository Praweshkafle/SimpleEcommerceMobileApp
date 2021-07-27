using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPosMobile.Models
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int user_id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public bool is_active { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public int created_by { get; set; }
        public DateTime created_date { get; set; }
        public string primary_contact { get; set; }
        public string secondary_contact { get; set; }
        public string role_name { get; set; }
        public string token { get; set; }
        public string image_path { get; set; }
        public int password_change_count { get; set; }
        public string refresh_token { get; set; }
        public string organization_name { get; set; }
        public string organization_address { get; set; }
        public string organization_contact_no { get; set; }
        public string organization_logo { get; set; }
        public DateTime package_expiry_date { get; set; }

    }
}
