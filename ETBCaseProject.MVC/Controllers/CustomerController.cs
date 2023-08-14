using AutoMapper;
using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Services;
using ETBCaseProject.MVC.Models.CustomerViewModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace ETBCaseProject.MVC.Controllers
{
    /// <summary>
    /// Customer işlemlerini yönetmek için Controller sınıfı.
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
        /// <param name="page">Sayfa numarası</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(_mapper.Map<List<CustomerListVM>>(await _customerService.GetAllWithoutTrackingAsync()).OrderBy(x => x.Name).ToPagedList(page, 8));
        }
        /// <summary>
        /// Müşteri aramak için kullanılan HTTP POST işlemi
        /// </summary>
        /// <param name="SearchText">Aranacak metin</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Index(string SearchText = "")
        {
            return View(_mapper.Map<List<CustomerListVM>>(await _customerService.GetAllWithoutTrackingAsync()).OrderBy(x => x.Name).Where(x => x.Name.Contains(SearchText)).ToPagedList());
        }
        /// <summary>
        /// Müşteri detaylarını görüntülemek için kullanılan HTTP GET işlemi
        /// </summary>
        /// <param name="id">Müşteri Id'si</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            return View(_mapper.Map<CustomerDetailsVM>(await _customerService.GetByIdAsync(id)));
        }
        [HttpGet]
        /// <summary>
        /// Yeni Customer oluşturmak için kullanılan HTTP GET işlemi
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Yeni Customer oluşturmak için kullanılan HTTP POST işlemi
        /// </summary>
        /// <param name="customerCreateVM">Customer oluşturma veri modeli</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateVM customerCreateVM)
        {
            await _customerService.AddAsync(_mapper.Map<Customer>(customerCreateVM));
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// Customer güncellemek için kullanılan HTTP GET işlemi
        /// </summary>
        /// <param name="id">Customer Id'si</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            return View(_mapper.Map<CustomerUpdateVM>(await _customerService.GetByIdAsync(id)));
        }
        /// <summary>
        /// Customer güncellemek için kullanılan HTTP POST işlemi
        /// </summary>
        /// <param name="customerUpdateVM">Customer güncelleme veri modeli</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Update(CustomerUpdateVM customerUpdateVM)
        {
            await _customerService.UpdateAsync(_mapper.Map<Customer>(customerUpdateVM));
            return RedirectToAction(nameof(Index));
        }
        /// <summary>
        /// Customer silmek için kullanılan HTTP GET işlemi
        /// </summary>
        /// <param name="id">Customer Id'si</param>
        /// <returns>Customer silme sonucunu JSON olarak döndürme</returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return Json(await _customerService.RemoveWithAjaxAsync(await _customerService.GetByIdAsync(id)));
        }
    }
}
