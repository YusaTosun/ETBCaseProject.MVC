using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;
using ETBCaseProject.Core.Utilities.Results;
using ETBCaseProject.Core.Utilities.Results.Concrete;

namespace ETBCaseProject.Services.Services
{
    /// <summary>
    /// Customer entity'si için özelleşmiş Service sınıfı,İçerisinde dönüş tipleri Dto olan Customer entity'sine özgü methodlar barındıracak
    /// </summary>
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository customerRepository) : base(unitOfWork, customerRepository)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = customerRepository;
        }
        
    }
}
