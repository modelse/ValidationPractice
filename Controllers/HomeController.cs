using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validationPractice.Models;

namespace validationPractice.Controllers
{

    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors="";
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid) {
                return RedirectToAction("Success");
            }
            ViewBag.errors=ModelState.Values;
            return View("Index");
        }

        [HttpPost]
        [Route("back")]
        public IActionResult Back()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("success")]
        public IActionResult Success(){
            return View("success");
        }
    }
}
