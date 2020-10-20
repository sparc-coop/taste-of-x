using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElSaborDe.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string[] Category { get; set; }

        public string[] Cuisine { get; set; }
        public string OpeningHours { get; set; }
        public string ClosingHoours { get; set; }
        public string[] DaysOpen { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string About { get; set; }
    }
}
