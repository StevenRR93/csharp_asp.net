using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Time_display.Controllers
{
    public class time_display_Controller : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult i()
        {
            return View("index");
        }
        [HttpGet]
        [Route("index")]
        public IActionResult index()
        {
            return View("index");
        }
    }
}