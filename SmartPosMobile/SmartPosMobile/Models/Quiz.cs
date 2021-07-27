using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPosMobile.Models
{
    public class Quiz
    {
        public long Id { get; set; }
        public string Question { get; set; }
        public string option_1 { get; set; }
        public string option_2 { get; set; }
        public string answer { get; set; }
    }

}
