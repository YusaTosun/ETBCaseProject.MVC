using ETBCaseProject.Core.Models;

namespace ETBCaseProject.Core.Repositories
{
    /// <summary>
    /// Customer Methodları için özelleşmiş Interface
    /// </summary>
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        ///Customer'a özel repolar içerecek
    }
}
