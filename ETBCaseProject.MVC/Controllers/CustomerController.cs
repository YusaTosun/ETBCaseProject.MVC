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

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<List<CustomerListVM>>(await _customerService.GetAllWithoutTrackingAsync()));
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
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(_mapper.Map<CustomerUpdateVM>(await _customerService.GetByIdAsync(id)));
        }
        [HttpPost]
        public async Task<IActionResult> Update(CustomerUpdateVM customerUpdateVM)
        {
            await _customerService.UpdateAsync(_mapper.Map<Customer>(customerUpdateVM));
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await _customerService.RemoveAsync(await _customerService.GetByIdAsync(id));
            return RedirectToAction(nameof(Index));
        }
    }
}
