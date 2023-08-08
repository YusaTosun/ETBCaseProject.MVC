using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Services;
using ETBCaseProject.Repository;
using ETBCaseProject.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Services.Services
{
    public class CustomerService : GenericRepository<Customer>, ICustomerService
    {
        public CustomerService(EtbDbContext context) : base(context)
        {
        }
    }
}
