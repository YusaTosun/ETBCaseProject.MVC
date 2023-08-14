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
        /// <summary>
        /// Verilen nesneyi veritabanında ajax ile silindi olarak işaretler.SoftDelete işlemi gerçekleştirir
        /// </summary>
        /// <param name="entity">Silinmek istenen Customer</param>
        /// <returns>Ajax işlemlerine uygun Result nesnesi döner.</returns>
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
