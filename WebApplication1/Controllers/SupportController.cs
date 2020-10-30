using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SupportController : Controller
    {
        [HttpGet]
        public IActionResult Contact() //for loading page
        {
            return View();
        }   

        [HttpPost]
        public IActionResult Contact(string email, string query) //handling form submission
        {
            if (string.IsNullOrEmpty(query))
                ViewData["warning"] = "Type a question!";
            else
                ViewData["feedback"] = "Thank you for your question. We will get in touch with you soon";
            return View();
        }
    }
}
