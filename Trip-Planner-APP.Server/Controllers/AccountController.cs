﻿using Microsoft.AspNetCore.Mvc;

namespace Trip_Planner_APP.Server.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
