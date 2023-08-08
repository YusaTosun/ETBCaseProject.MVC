using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;

namespace ETBCaseProject.Repository.Repositories
{
    /// <summary>
    /// Customer için özelleştirilmiş repository sınıfı
    /// </summary>
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(EtbDbContext context) : base(context)
        {
        }
    }
}
