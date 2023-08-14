using AutoMapper;
using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Services;
using ETBCaseProject.MVC.Models.CustomerViewModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace ETBCaseProject.MVC.Controllers
{
    /// <summary>
    /// Müşteri işlemlerini yönetmek için Controller sınıfı.
    /// </summary>
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _mapper = mapper;
            _customerService = customerService;
        }
        /// <summary>
        /// Tüm müşterileri listelemek için kullanılan HTTP GET işlemi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(_mapper.Map<List<CustomerListVM>>(await _customerService.GetAllWithoutTrackingAsync()).OrderBy(x => x.Name).ToPagedList(page,5));
        }
        [HttpPost]
        public async Task<IActionResult> Index(string SearchText = "")
        {
            return View(_mapper.Map<List<CustomerListVM>>(await _customerService.GetAllWithoutTrackingAsync()).OrderBy(x => x.Name).Where(x => x.Name.Contains(SearchText)).ToPagedList());
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(_mapper.Map<CustomerDetailsVM>(await _customerService.GetByIdAsync(id)));
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
            return Json(await _customerService.RemoveWithAjaxAsync(await _customerService.GetByIdAsync(id)));
        }
    }
}
