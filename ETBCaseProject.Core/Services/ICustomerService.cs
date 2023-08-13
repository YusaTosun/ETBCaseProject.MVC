using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.UnitOfWorks;
using ETBCaseProject.Core.Utilities.Results.Concrete;
using ETBCaseProject.Core.Utilities.Results;

namespace ETBCaseProject.Core.Services
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Task<IResult> RemoveWithAjaxAsync(Customer entity);

        Task<IResult> RemoveRangeWithAjaxAsync(IEnumerable<Customer> entities);
    }
}
