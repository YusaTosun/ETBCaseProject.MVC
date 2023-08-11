using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;

namespace ETBCaseProject.Services.Services
{
    /// <summary>
    /// Customer entity'si için özelleşmiş Service sınıfı,İçerisinde dönüş tipleri Dto olan Customer entity'sine özgü methodlar barındıracak
    /// </summary>
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _repository;
        public CustomerService(IUnitOfWork unitOfWork, ICustomerRepository repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
