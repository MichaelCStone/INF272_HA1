using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21497682_HA1.Models
{
    public class Booking
    {
        public int hotelId { get; set; }
        public Guid BookingId { get; set; }
        public DateTime BookingDateTime { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public string IdType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string MealOption { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public string Features { get; set; }

        public Booking()
        {
            BookingId = Guid.NewGuid();
        }
    }
}