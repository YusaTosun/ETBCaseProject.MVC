using ETBCaseProject.Core.Models;
using ETBCaseProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Core.Services
{
    public interface ICustomerService:IGenericRepository<Customer>
    {
    }
}
