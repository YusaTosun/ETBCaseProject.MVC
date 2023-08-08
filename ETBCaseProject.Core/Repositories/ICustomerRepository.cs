using ETBCaseProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBCaseProject.Core.Repositories
{
    /// <summary>
    /// Customer Methodları için özelleşmiş Interface
    /// </summary>
    public interface ICustomerRepository:IGenericRepository<Customer>
    {
        ///Customer'a özel repolar içerecek
    }
}
