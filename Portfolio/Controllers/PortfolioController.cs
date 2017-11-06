using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {   
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            return View("Home");
        }
        [HttpGet]
        [Route("Home")]
        public IActionResult Home()
        {
            return View("Home");
        }
        [HttpGet]
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }
        [HttpGet]
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}