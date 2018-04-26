using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet("home")]
        public IActionResult Home()
        {
            return View("Home");
        }

        [HttpPost("result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
           ViewBag.Name = name;
           ViewBag.Location = location;
           ViewBag.Language = language;
           ViewBag.Comment = comment;
           return View();
        }
    }

}