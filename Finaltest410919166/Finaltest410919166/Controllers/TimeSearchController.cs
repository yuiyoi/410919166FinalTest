using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finaltest410919166.Controllers
{
    public class TimeSearchController : Controller
    {
        // GET: TimeSearch
        public ActionResult Index(String name, float? number)
        {

            var result = "";
            if (number == 13)
            {
                result = "下午1點";
            }
            else if (number == 14)
            {
                result = "下午2點";
            }
            else if (number == 15)
            {
                result = "下午3點";
            }
            else if (number == 16)
            {
                result = "下午4點";
            }
            else if (number == 17)
            {
                result = "下午5點";
            }
            else if (number == 18)
            {
                result = "下午6點";
            }
            else
            {
                result = "錯誤";
            }

            ViewBag.yourName = name;
            ViewBag.result = result;

            return View();
        }
    }
}