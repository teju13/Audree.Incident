using Audree.Incident.Application.DTO_s.Masters;
using Audree.Incident.Core.Contracts.IRepository;
using Audree.Incident.Core.Models.Masters;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audree.Incident.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Private fields  
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private ICustomerRepository customerrepository;
        #endregion
        public CustomerController(ICustomerRepository customerrepository, IMapper mapper)
        {
            _customerRepository = customerrepository;
            _mapper = mapper;
        }
        #region GETALL
        /// <summary>
        /// Purpose     : TO GetALL Details
        /// Created By  : Audree Infotech Pvt. Ltd.
        /// Created On :  20-3-2021
        /// Employee Id: 100236
        /// </summary>
        /// <param name="CustomerController"></param>
        /// <returns></returns>
        // GET api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _customerRepository.GetAllCustomerdetails());
        }
        #endregion
        #region CreateUpdate
        /// <summary>
        /// Purpose : To CreateOrUpdate 
        /// Created By : Audree Infotech Pvt. Ltd.
        /// Created On : 28-06-21
        /// Employee Id: 100236
        /// </summary>
        /// <param name="customerDto"></param>
        /// <returns></returns>
        // POST api/<controller>
        [HttpPost("CreateorUpdate")]
        public async Task<IActionResult> CreateorUpdate([FromBody] CustomerDTO customerDto)
        {
            return Ok(await _customerRepository.CreateOrUpdate(_mapper.Map<Customer>(customerDto)));

        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] CustomerDTO customerDto)
        {
            return Ok(await _customerRepository.Delete(_mapper.Map<Customer>(customerDto)));

        }
        #endregion
    }
}

