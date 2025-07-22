using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21497682_HA1.Models;

namespace u21497682_HA1.Controllers
{
    public class HotelController : Controller
    {
        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Meals()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Hotels(int? hotelID)
        {
            HotelDataRepository data = new HotelDataRepository();

            if (hotelID.HasValue)
            {
                return View(data);
            }
            else
            {
                return View(data);
            }
        }

        public ActionResult BookingConfirmed()
        {
            return View();
        }

        public ActionResult MealAgents()
        {
            return View();
        }

        public ActionResult MealOrders()
        {
            return View();
        }

        public ActionResult ViewOrder()
        {
            return View();
        }
    }
}