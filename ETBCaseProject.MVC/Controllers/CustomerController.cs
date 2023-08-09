using AutoMapper;
using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Services;
using ETBCaseProject.MVC.Models.CustomerViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ETBCaseProject.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService,IMapper mapper)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<CustomerListVM>>(await _customerService.GetAllAsync()));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateVM customerCreateVM)
        {
            await _customerService.AddAsync(_mapper.Map<Customer>(customerCreateVM));
            return RedirectToAction(nameof(CustomerController.Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id) 
        {
            var customer = await _customerService.GetByIdAsync(id);
            var updateCustomerVM = _mapper.Map<CustomerUpdateVM>(customer);
            return View(updateCustomerVM);
        }
    }
}
