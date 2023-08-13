using ETBCaseProject.Business.Constants;
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
        public async Task<IResult> RemoveRangeWithAjaxAsync(IEnumerable<Customer> entities)
        {
            if (entities is not null && entities.Count() != 0)
            {
                _customerRepository.RemoveRange(entities);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(Messages.DeleteSuccess);
            }
            return new ErrorResult(Messages.NullData);
        }
        public async Task<IResult> RemoveWithAjaxAsync(Customer entity)
        {
            if (entity is not null)
            {
                _customerRepository.Remove(entity);
                await _unitOfWork.CommitAsync();
                return new SuccessResult(Messages.DeleteSuccess);
            }
            return new ErrorResult(Messages.NullData);
        }
    }
}
