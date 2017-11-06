// Inside your Controller class
// Other code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// using System.Web.Mvc;
// using System.Web.Mvc.Ajax;
using Microsoft.AspNetCore.Mvc;
 
namespace Calling_card.controllers
{
    public class calling_card_controller : Controller
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "Hello World!";
        }
        [HttpGet]
        [Route("displayint")]
        public JsonResult DisplayInt()
        {
            return Json(1);
        }
        // Other code
        // Other code
        [HttpGet]
        [Route("{first_name}/{last_name}/{age}/{favorite_color}")]
        public JsonResult Index(string first_name, string last_name, int age, string favorite_color)
        {
            var AnonObject = new {
                FirstName = first_name,
                LastName = last_name,
                Age = age,
                FavoriteColor = favorite_color
            };
            return Json(AnonObject);
        }
    }
}

