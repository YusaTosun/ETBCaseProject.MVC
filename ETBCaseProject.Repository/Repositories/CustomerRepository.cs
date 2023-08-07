using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, IGenericRepository<Customer>
    {
        public CustomerRepository(EtbDbContext context) : base(context)
        {
        }
    }
}
