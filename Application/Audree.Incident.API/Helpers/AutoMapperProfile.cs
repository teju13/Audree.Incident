using Audree.Incident.Application.DTO_s.Masters;
using Audree.Incident.Core.Models.Masters;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audree.Incident.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();

        }
    }
}
