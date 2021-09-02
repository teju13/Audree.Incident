using Audree.Incident.Core.Models.Masters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Audree.Incident.Core.Contracts.IRepository
{
   public interface ICustomerRepository
    {
        Task<string> CreateOrUpdate(Customer customer);
        Task<string> Delete(Customer customer);
        Task<List<Customer>> GetAllCustomerdetails();
    }
}
