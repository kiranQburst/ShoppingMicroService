using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Application.Features.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public string Username { get; set; }
        public GetOrdersListQuery(string userName)
        {
            Username = userName;
        }
    }
}
