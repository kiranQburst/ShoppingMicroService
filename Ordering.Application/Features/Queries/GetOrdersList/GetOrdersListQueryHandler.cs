using AutoMapper;
using MediatR;
using Ordering.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ordering.Application.Features.Queries.GetOrdersList
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, List<OrdersVm>>
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IMapper _mapper;

        public GetOrdersListQueryHandler(IOrderRepo orderRepo, IMapper mapper)
        {
            _orderRepo = orderRepo;
            _mapper = mapper;
        }

        public async System.Threading.Tasks.Task<List<OrdersVm>> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
        {
            var ordersList = await _orderRepo.GetOrdersByUserName(request.Username);
            return _mapper.Map<List<OrdersVm>>(ordersList);
        }
    }
}
