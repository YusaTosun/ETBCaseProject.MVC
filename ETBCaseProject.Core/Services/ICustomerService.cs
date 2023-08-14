using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Utilities.Results;

namespace ETBCaseProject.Core.Services
{
    public interface ICustomerService : IGenericService<Customer>
    {
        Task<IResult> RemoveWithAjaxAsync(Customer entity);
    }
}
