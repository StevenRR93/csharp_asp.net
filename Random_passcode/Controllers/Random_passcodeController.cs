using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Random_passcode.Controllers
{
    public class Random_passcodeController : Controller
    {   
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            try{
                HttpContext.Session.GetInt32("count");
            }
            catch{
                HttpContext.Session.SetInt32("count", 0);
            }
            if (!HttpContext.Session.GetInt32("count").HasValue){
                HttpContext.Session.SetInt32("count", 0);
            }
            if (HttpContext.Session.GetInt32("count") == 0){
                return RedirectToAction("Generate");
            }
            ViewBag.Count = HttpContext.Session.GetInt32("count").Value;
            ViewBag.Passcode = HttpContext.Session.GetString("passcode");
            return View("Random_passcode");
        }
        [HttpGet]
        [Route("Generate")]
        public IActionResult generate()
        {
            try{
                HttpContext.Session.GetInt32("count");
            }
            catch{
                HttpContext.Session.SetInt32("count", 0);
            }
            int temp = 0;
            if(HttpContext.Session.GetInt32("count").HasValue){
                temp = HttpContext.Session.GetInt32("count").Value;
            }
            else{
                HttpContext.Session.SetInt32("count", 0);
            }
            HttpContext.Session.SetInt32("count", temp +1);
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[14];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string passcode = new String(stringChars);
            HttpContext.Session.SetString("passcode", passcode);
            return RedirectToAction("index");
        }
        [HttpGet]
        [Route("Clear")]
        public IActionResult clear()
        {
            HttpContext.Session.SetInt32("count", 0);
            return RedirectToAction("Generate");
        }
    }
}