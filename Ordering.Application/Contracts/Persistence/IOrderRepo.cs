﻿using Ordering.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence
{
    public interface IOrderRepo : IAsyncRepo<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
