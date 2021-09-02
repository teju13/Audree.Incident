using Audree.Incident.Core.Contracts.IRepository;
using Audree.Incident.Core.Contracts.IUnitOfWork;
using Audree.Incident.Core.Models.Masters;
using Audree.Incident.Infrastructure.Data;
using Audree.Incident.Infrastructure.ToDo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Audree.Incident.Infrastructure.ToDo.CommonEnum;


namespace Audree.Incident.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        
            #region Private fields  
            private readonly IUnitOfWork _UnitOfWork;
            private readonly CustomerContext _baseContext;
            #endregion
            #region DependencyInjection
            public CustomerRepository(IUnitOfWork unitOfWork, CustomerContext baseContext)
            {
                _UnitOfWork = unitOfWork;
                _baseContext = baseContext;
            }

        public object EnumUserActions { get; private set; }
        #endregion
        #region AddorUpdate
        /// <summary>
        /// Purpose     :  Add or Update Sample
        /// Created By  :  Audree Infotech Pvt. Ltd.
        /// Created On	:  28-06-21
        /// </summary>
        /// <param name="sample"></param>
        /// <returns></returns>

        public async Task<string> CreateOrUpdate(Customer customer)
            {
                string Message = "";
                using (var transaction = _baseContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (customer.Id == 0)
                        {
                            _baseContext.Customers.Add(customer);
                        //customer.Status = (int)EnumUserActions.Enabled;
                            _baseContext.SaveChanges();

                            //EnumHelper<Messages>.GetDisplayValue(Messages.CustomCreated);
                        }
                        else
                        {
                            Customer g1 = await _baseContext.Customers.AsNoTracking().Where(w => w.Id == customer.Id).FirstOrDefaultAsync();
                            g1.CustomerName = customer.CustomerName;
                         
                           
                            _baseContext.Customers.Update(g1);
                        }
                        _baseContext.SaveChanges();
                        EnumHelper<Messages>.GetDisplayValue(Messages.CustomCreated);

                        transaction.Commit();
                    }
                    catch (Exception Ex)
                    {
                        Message = "Error,In Posting";
                        transaction.Rollback();
                    }
                }
                return Message;
            }
        public async Task<string> Delete(Customer customer)
        {
            string Message = "";
            using (var transaction = _baseContext.Database.BeginTransaction())
            {
                try
                {
                    if (customer.Id == 0)
                    {
                        _baseContext.Customers.Add(customer);
                        //customer.Status = (int)EnumUserActions.Enabled;
                        _baseContext.SaveChanges();

                        //EnumHelper<Messages>.GetDisplayValue(Messages.CustomCreated);
                    }
                    else
                    {
                        Customer g1 = await _baseContext.Customers.AsNoTracking().Where(w => w.Id == customer.Id).FirstOrDefaultAsync();
                        g1.CustomerName = customer.CustomerName;


                        _baseContext.Customers.Update(g1);
                    }
                    _baseContext.SaveChanges();
                    EnumHelper<Messages>.GetDisplayValue(Messages.CustomCreated);

                    transaction.Commit();
                }
                catch (Exception Ex)
                {
                    Message = "Error,In Posting";
                    transaction.Rollback();
                }
            }
            return Message;
        }


        #endregion
        #region GetSample
        /// <summary>
        /// Purpose     :   To Get Customer List
        /// Created By  :   Audree Infotech Pvt. Ltd.
        /// Created On	:  20-03-21
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public async Task<List<Customer>> GetAllCustomerdetails()
            {
                try
                {
                    using (_UnitOfWork)
                    {
                        var sample = await _baseContext.Customers.ToListAsync();
                        return sample;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            #endregion
        }
    }

