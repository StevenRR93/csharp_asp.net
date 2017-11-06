using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Dojo_survey.Controllers
{
    public class SurveyController : Controller
    {   
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            return View("survey");
        }
        [HttpGet]
        [Route("Survey")]
        public IActionResult survey()
        {
            return View("survey");
        }
        [HttpPost]
        [Route("Process")]
        public IActionResult process(string name, string location, string language, string comment)
        {
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetString("location", location);
            HttpContext.Session.SetString("language", language);
            HttpContext.Session.SetString("comment", comment);
            return RedirectToAction("Result");
        }
        [HttpGet]
        [Route("Result")]
        public IActionResult result()
        {
            ViewBag.name = HttpContext.Session.GetString("name");
            ViewBag.location = HttpContext.Session.GetString("location");
            ViewBag.language = HttpContext.Session.GetString("language");
            ViewBag.comment = HttpContext.Session.GetString("comment");
            return View("result");
        }
    }
}