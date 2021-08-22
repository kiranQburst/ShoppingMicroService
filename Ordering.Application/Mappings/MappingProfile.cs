using AutoMapper;
using Ordering.Application.Features.Queries.GetOrdersList;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Application.Mappings
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
        }
    }
}
