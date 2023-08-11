using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using ETBCaseProject.Core.Utilities.Results.Concrete;
using ETBCaseProject.Core.Utilities.Results;

namespace ETBCaseProject.Core.Services
{
    public interface ICustomerService : IGenericService<Customer>
    {
       Task<IDataResult<Customer>> AddCustomerAsync(Customer customer);
    }
}
