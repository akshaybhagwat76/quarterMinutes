using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> picktime = new List<SelectListItem>();
            picktime.Add(new SelectListItem { Text = "12:00 AM", Value = "00:00" });
            picktime.Add(new SelectListItem { Text = "12:15 AM", Value = "00:15" });
            picktime.Add(new SelectListItem { Text = "12:30 AM", Value = "00:30" });
            picktime.Add(new SelectListItem { Text = "12:45 AM", Value = "00:45" });
            picktime.Add(new SelectListItem { Text = "01:00 AM", Value = "01:00" });
            picktime.Add(new SelectListItem { Text = "01:15 AM", Value = "01:15" });
            picktime.Add(new SelectListItem { Text = "01:30 AM", Value = "01:30" });
            picktime.Add(new SelectListItem { Text = "01:45 AM", Value = "01:45" });
            picktime.Add(new SelectListItem { Text = "02:00 AM", Value = "02:00" });
            picktime.Add(new SelectListItem { Text = "02:15 AM", Value = "02:15" });
            picktime.Add(new SelectListItem { Text = "02:30 AM", Value = "02:30" });
            picktime.Add(new SelectListItem { Text = "02:45 AM", Value = "02:45" });
            picktime.Add(new SelectListItem { Text = "03:00 AM", Value = "03:00" });
            picktime.Add(new SelectListItem { Text = "03:15 AM", Value = "03:15" });
            picktime.Add(new SelectListItem { Text = "03:30 AM", Value = "03:30" });
            picktime.Add(new SelectListItem { Text = "03:45 AM", Value = "03:45" });
            picktime.Add(new SelectListItem { Text = "04:00 AM", Value = "04:00" });
            picktime.Add(new SelectListItem { Text = "04:15 AM", Value = "04:15" });
            picktime.Add(new SelectListItem { Text = "04:30 AM", Value = "04:30" });
            picktime.Add(new SelectListItem { Text = "04:45 AM", Value = "04:45" });
            picktime.Add(new SelectListItem { Text = "05:00 AM", Value = "05:00" });
            picktime.Add(new SelectListItem { Text = "05:15 AM", Value = "05:15" });
            picktime.Add(new SelectListItem { Text = "05:30 AM", Value = "05:30" });
            picktime.Add(new SelectListItem { Text = "05:45 AM", Value = "05:45" });
            picktime.Add(new SelectListItem { Text = "06:00 AM", Value = "06:00" });
            picktime.Add(new SelectListItem { Text = "06:15 AM", Value = "06:15" });
            picktime.Add(new SelectListItem { Text = "06:30 AM", Value = "06:30" });
            picktime.Add(new SelectListItem { Text = "06:45 AM", Value = "06:45" });
            picktime.Add(new SelectListItem { Text = "07:00 AM", Value = "07:00" });
            picktime.Add(new SelectListItem { Text = "07:15 AM", Value = "07:15" });
            picktime.Add(new SelectListItem { Text = "07:30 AM", Value = "07:30" });
            picktime.Add(new SelectListItem { Text = "07:45 AM", Value = "07:45" });
            picktime.Add(new SelectListItem { Text = "08:00 AM", Value = "08:00" });
            picktime.Add(new SelectListItem { Text = "08:15 AM", Value = "08:15" });
            picktime.Add(new SelectListItem { Text = "08:30 AM", Value = "08:30" });
            picktime.Add(new SelectListItem { Text = "08:45 AM", Value = "08:45" });
            picktime.Add(new SelectListItem { Text = "09:00 AM", Value = "09:00" });
            picktime.Add(new SelectListItem { Text = "09:15 AM", Value = "09:15" });
            picktime.Add(new SelectListItem { Text = "09:30 AM", Value = "09:30" });
            picktime.Add(new SelectListItem { Text = "09:45 AM", Value = "09:45" });
            picktime.Add(new SelectListItem { Text = "10:00 AM", Value = "10:00" });
            picktime.Add(new SelectListItem { Text = "10:15 AM", Value = "10:15" });
            picktime.Add(new SelectListItem { Text = "10:30 AM", Value = "10:30" });
            picktime.Add(new SelectListItem { Text = "10:45 AM", Value = "10:45" });
            picktime.Add(new SelectListItem { Text = "11:00 AM", Value = "11:00" });
            picktime.Add(new SelectListItem { Text = "11:15 AM", Value = "11:15" });
            picktime.Add(new SelectListItem { Text = "11:30 AM", Value = "11:30" });
            picktime.Add(new SelectListItem { Text = "11:45 AM", Value = "11:45" });
            picktime.Add(new SelectListItem { Text = "12:00 PM", Value = "12:00" });
            picktime.Add(new SelectListItem { Text = "12:15 PM", Value = "12:15" });
            picktime.Add(new SelectListItem { Text = "12:30 PM", Value = "12:30" });
            picktime.Add(new SelectListItem { Text = "12:45 PM", Value = "12:45" });
            picktime.Add(new SelectListItem { Text = "01:00 PM", Value = "13:00" });
            picktime.Add(new SelectListItem { Text = "01:15 PM", Value = "13:15" });
            picktime.Add(new SelectListItem { Text = "01:30 PM", Value = "13:30" });
            picktime.Add(new SelectListItem { Text = "01:45 PM", Value = "13:45" });
            picktime.Add(new SelectListItem { Text = "02:00 PM", Value = "14:00" });
            picktime.Add(new SelectListItem { Text = "02:15 PM", Value = "14:15" });
            picktime.Add(new SelectListItem { Text = "02:30 PM", Value = "14:30" });
            picktime.Add(new SelectListItem { Text = "02:45 PM", Value = "14:45" });
            picktime.Add(new SelectListItem { Text = "03:00 PM", Value = "15:00" });
            picktime.Add(new SelectListItem { Text = "03:15 PM", Value = "15:15" });
            picktime.Add(new SelectListItem { Text = "03:30 PM", Value = "15:30" });
            picktime.Add(new SelectListItem { Text = "03:45 PM", Value = "15:45" });
            picktime.Add(new SelectListItem { Text = "04:00 PM", Value = "16:00" });
            picktime.Add(new SelectListItem { Text = "04:15 PM", Value = "16:15" });
            picktime.Add(new SelectListItem { Text = "04:30 PM", Value = "16:30" });
            picktime.Add(new SelectListItem { Text = "04:45 PM", Value = "16:45" });
            picktime.Add(new SelectListItem { Text = "05:00 PM", Value = "17:00" });
            picktime.Add(new SelectListItem { Text = "05:15 PM", Value = "17:15" });
            picktime.Add(new SelectListItem { Text = "05:30 PM", Value = "17:30" });
            picktime.Add(new SelectListItem { Text = "05:45 PM", Value = "17:45" });
            picktime.Add(new SelectListItem { Text = "06:00 PM", Value = "18:00" });
            picktime.Add(new SelectListItem { Text = "06:15 PM", Value = "18:15" });
            picktime.Add(new SelectListItem { Text = "06:30 PM", Value = "18:30" });
            picktime.Add(new SelectListItem { Text = "06:45 PM", Value = "18:45" });
            picktime.Add(new SelectListItem { Text = "07:00 PM", Value = "19:00" });
            picktime.Add(new SelectListItem { Text = "07:15 PM", Value = "19:15" });
            picktime.Add(new SelectListItem { Text = "07:30 PM", Value = "19:30" });
            picktime.Add(new SelectListItem { Text = "07:45 PM", Value = "19:45" });
            picktime.Add(new SelectListItem { Text = "08:00 PM", Value = "20:00" });
            picktime.Add(new SelectListItem { Text = "08:15 PM", Value = "20:15" });
            picktime.Add(new SelectListItem { Text = "08:30 PM", Value = "20:30" });
            picktime.Add(new SelectListItem { Text = "08:45 PM", Value = "20:45" });
            picktime.Add(new SelectListItem { Text = "09:00 PM", Value = "21:00" });
            picktime.Add(new SelectListItem { Text = "09:15 PM", Value = "21:15" });
            picktime.Add(new SelectListItem { Text = "09:30 PM", Value = "21:30" });
            picktime.Add(new SelectListItem { Text = "09:45 PM", Value = "21:45" });
            picktime.Add(new SelectListItem { Text = "10:00 PM", Value = "22:00" });
            picktime.Add(new SelectListItem { Text = "10:15 PM", Value = "22:15" });
            picktime.Add(new SelectListItem { Text = "10:30 PM", Value = "22:30" });
            picktime.Add(new SelectListItem { Text = "10:45 PM", Value = "22:45" });
            picktime.Add(new SelectListItem { Text = "11:00 PM", Value = "23:00" });
            picktime.Add(new SelectListItem { Text = "11:15 PM", Value = "23:15" });
            picktime.Add(new SelectListItem { Text = "11:30 PM", Value = "23:30" });
            picktime.Add(new SelectListItem { Text = "11:45 PM", Value = "23:45" });
            ViewData["lst"] = picktime;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}