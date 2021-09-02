using Audree.Incident.Core.Models.Masters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audree.Incident.Infrastructure.Data
{
   public class CustomerContext: DbContext
    {
        #region DB Context
        //public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }
        #endregion
        public DbSet<Customer> Customers { get; set; }
        
    }
}
