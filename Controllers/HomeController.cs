using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Here is a message!";
            Message msg = new Message
            {
                content = "This is a really cool message. Hello."
            };
            return View(msg);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            ViewData["Title"] = "Here are some numbers!";
            Numbers num = new Numbers
            {
            num = new int[] {1,2,3,10,42,5}
            };
            return View(num);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            ViewData["Title"] = "Here are some Users!";
            Users users = new Users()
            {
                userList = new List<string>
                {
                    "Moose Philips", "Sarah", "Jess", "Eugene", "Rex", "Devon", "Insiya", "Brett Fishel"
                }
            };
            return View(users);
        }

        [HttpGet("user")]
        public new IActionResult User()
        {
            ViewData["Title"] = "Here is a User!";
            User user = new User()
            {
                user = "Brett Fishel"
            };
            return View(user);
        }
    }
}
