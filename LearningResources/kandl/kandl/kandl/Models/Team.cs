using kandl.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace kandl.Models
{
    public class Team
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public string BackgroundColor { get; set; }
        public string LabelColor { get; set; }
        public string TextColor { get; set; }
        public Team()
        {
            ID = Helper.GetRandomGUID();
            TextColor = "#000000";
            LabelColor = "#0010EF";
        }
    }
}
