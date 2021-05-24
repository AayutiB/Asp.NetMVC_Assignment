using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class DataPersistance : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SessinDemo()
        {
            HttpContext.Session.SetString("message", "session test");
            HttpContext.Session.SetInt32("count", 5);
            HttpContext.Session.SetString("dateobj", JsonSerializer(DateTime.Now));


            return RedirectToAction("GetSessionValues");
        }

        private string JsonSerializer(DateTime now)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetSessionValues()
        {
            ViewBag.message = HttpContext.Session.GetString("message");
            ViewBag.count = HttpContext.Session.GetInt32("count");
            return View();
        }


        public ActionResult WriteCookies(string setting, string settingValue, bool isPersistence)
        {
            if (isPersistence)
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append(setting,settingValue,options);

            }
            else
            {
                Response.Cookies.Append(setting, settingValue );
            }
            ViewBag.Message = "cookie written susscesfuly";
            return View("Index");
        }
        public ActionResult ReadCookies()
        {
            ViewBag.FontName = Request.Cookies["fontname"];
            ViewBag.FontSize = Request.Cookies["fontsize"];
            ViewBag.Color = Request.Cookies["color"];
            if (string.IsNullOrEmpty(ViewBag.FontName))
            {
                ViewBag.FontName = "Arial";

            }
            if (string.IsNullOrEmpty(ViewBag.FontName))
            {
                ViewBag.FontSize = "22px";

            }
            if (string.IsNullOrEmpty(ViewBag.FontName))
            {
                ViewBag.Color = "Black";

            }
            return View();

        }
    }
}
