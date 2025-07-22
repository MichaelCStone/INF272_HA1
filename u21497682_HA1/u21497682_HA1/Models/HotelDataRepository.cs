using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21497682_HA1.Models
{
    public class HotelDataRepository
    {
        private List<Hotel> hotels;

        public HotelDataRepository()
        {
            hotels = new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 1,
                    Name = "CapeHoney",
                    MealOptions = new List<MealOption>
                    {
                        new MealOption { Name = "Regular" },
                        new MealOption { Name = "Vegan" },
                        new MealOption { Name = "Gluten-free" }
                    },
                    RoomTypes = new List<RoomType>
                    {
                        new RoomType { Name = "Standard", Price = 3000, Features = "Breakfast excluded, Single bed, TV, Internet" },
                        new RoomType { Name = "Deluxe", Price = 5000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                        new RoomType { Name = "Exquisite", Price = 7000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator" },
                        new RoomType { Name = "Executive", Price = 10000, Features =  "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis" }
                    }
                },

                new Hotel
                {
                    HotelId = 2,
                    Name = "CapeIvory",
                    MealOptions = new List<MealOption>
                    {
                        new MealOption { Name = "Regular" },
                        new MealOption { Name = "Vegan" },
                        new MealOption { Name = "Halal" },
                        new MealOption { Name = "Kosher" },
                        new MealOption { Name = "Gluten-free" },
                        new MealOption { Name = "Keto" }
                    },
                    RoomTypes = new List<RoomType>
                    {
                        new RoomType { Name = "Single", Price = 2500, Features = "Breakfast excluded; single bed, TV, internet" },
                        new RoomType { Name = "Double", Price = 5000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                        new RoomType { Name = "Executive", Price = 8000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, buffet voucher" }
                    }
                },

                new Hotel
                {
                    HotelId = 3,
                    Name = "CapeSweet",
                    MealOptions = new List<MealOption>
                    {
                        new MealOption { Name = "Regular" },
                        new MealOption { Name = "Vegan" },
                        new MealOption { Name = "Halal" },
                        new MealOption { Name = "Kosher" }
                    },
                    RoomTypes = new List<RoomType>
                {
                    new RoomType { Name = "Tasty", Price = 3500, Features = "Breakfast included; two single beds, TV, internet" },
                    new RoomType { Name = "Comfort", Price = 5000, Features = "Breakfast included, two single beds, TV, internet, laundry, free parking" },
                    new RoomType { Name = "Executive", Price = 9000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, free parking, pet allowed, separate dining area" },
                    new RoomType { Name = "Diamond", Price = 12000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, free parking, pet allowed,  room service, separate dining area, buffet" }
                }
            },
            new Hotel
            {
                HotelId = 4,
                Name = "CapeHive",
                MealOptions = new List<MealOption>
                {
                    new MealOption { Name = "Regular" },
                    new MealOption { Name = "Vegan" },
                    new MealOption { Name = "Gluten-free" },
                    new MealOption { Name = "Paleo" }
                },
                RoomTypes = new List<RoomType>
                {
                    new RoomType { Name = "Standard", Price = 5000, Features = "Breakfast included, single bed, TV, internet, laundry, free parking" },
                    new RoomType { Name = "Double", Price = 7000, Features = "Breakfast included, double (2) single beds, TV, internet" },
                    new RoomType { Name = "Executive", Price = 10000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis" }
                }
            },
            new Hotel
            {
                HotelId = 5,
                Name = "CapeCow",
                MealOptions = new List<MealOption>
                {
                    new MealOption { Name = "Regular" },
                    new MealOption { Name = "Vegan" },
                    new MealOption { Name = "Halal" },
                    new MealOption { Name = "Kosher" },
                    new MealOption { Name = "Indian" }
                },
                    RoomTypes = new List<RoomType>
                    {
                        new RoomType { Name = "Budget", Price = 2500, Features = "Breakfast excluded; single bed, TV, internet" },
                        new RoomType { Name = "Spotlight", Price = 4000, Features = "Breakfast included; two single beds, TV, internet" },
                        new RoomType { Name = "Deluxe", Price = 6000, Features = "Breakfast included, single bed, TV, internet, laundry, free parking, tourism tour of Capetropolis." },
                        new RoomType { Name = "Gold", Price = 8000, Features = "Breakfast included, single bed, TV, internet, complimentary drinks in refrigerator, laundry, free parking, tourism tour of Capetropolis." },
                        new RoomType { Name = "Diamond", Price = 12000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis" },
                        new RoomType { Name = "Platinum", Price = 15000, Features = "Breakfast included, queen-sized double beds, TV, internet, complimentary drinks in refrigerator; laundry, room service, tourism tour of Capetropolis" }
                    }
                }
            };
        }

        public List<Hotel> GetAllHotels()
        {
            return hotels;
        }

        public Hotel GetHotelById(int hotelID)
        {
            return hotels.FirstOrDefault(h => h.HotelId == hotelID);
        }

        public List<MealOption> GetMealOptionsByHotelId(int hotelID)
        {
            var hotel = GetHotelById(hotelID);
            return hotel?.MealOptions;
        }

        public List<RoomType> GetRoomTypesByHotelId(int hotelID)
        {
            var hotel = GetHotelById(hotelID);
            return hotel?.RoomTypes;
        }
    }
}