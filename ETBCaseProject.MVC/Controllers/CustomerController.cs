﻿using Microsoft.AspNetCore.Mvc;

namespace ETBCaseProject.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
