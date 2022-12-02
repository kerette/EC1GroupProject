using AutoMapper;
using EC1GroupProject.Dtos;
using EC1GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC1GroupProject.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();

            Mapper.CreateMap<Payment, PaymentDto>();
            Mapper.CreateMap<AccountModel, AccountDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.TRN, opt => opt.Ignore());

            Mapper.CreateMap<PaymentDto, Payment>()
                    .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<AccountDto, AccountModel>()
                    .ForMember(c => c.AccountNumber, opt => opt.Ignore());
        }
    }
}