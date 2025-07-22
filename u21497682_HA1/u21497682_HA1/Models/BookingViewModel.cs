using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21497682_HA1.Models
{
    public class BookingViewModel
    {
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public List<string> IDType { get; set; } = new List<string> { "South African ID", "Passport" };
        public List<MealOption> MealOptions { get; set; }
        public List<RoomType> RoomTypes { get; set; }
        public Booking HotelBooking { get; set; } = new Booking();
    }
}