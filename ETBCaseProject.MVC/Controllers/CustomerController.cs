﻿using ETBCaseProject.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ETBCaseProject.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _customerService.GetAllAsync());
        }
    }
}
