using AutoMapper;
using MVC_FIRST_PROJECT.Dtos;
using MVC_FIRST_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_FIRST_PROJECT.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
        
    }
}