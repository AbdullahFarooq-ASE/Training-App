using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Training_App.Models;

namespace Training_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Date> dates = new List<Date>();
            for (int i = 0; i < 10; i++)
            {
                dates.Add(new Date() { date_time = i });
            }
            return View(dates);
        }
    }
}