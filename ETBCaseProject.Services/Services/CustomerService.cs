using AutoMapper;
using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Core.UnitOfWorks;

namespace ETBCaseProject.Services.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _repository;
        public CustomerService(IMapper mapper, IUnitOfWork unitOfWork, ICustomerRepository repository) : base(mapper, unitOfWork, repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }
}
