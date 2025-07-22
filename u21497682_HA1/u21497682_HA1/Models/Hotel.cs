using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21497682_HA1.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public List<RoomType> RoomTypes { get; set; }

        public List<MealOption> MealOptions { get; set; }
    }
}