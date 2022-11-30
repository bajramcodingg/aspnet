using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Developer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Developer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info(string Name,string Email,string Subject,string Message)
        {
            User user = new User()
            { Name=Name,
            Email=Email,
            Message=Message,
            Subject=Subject
            
            };

            return Content(user.Name+" "+user.Email+" "+user.Subject+" "+user.Message);
        }
    }
}
