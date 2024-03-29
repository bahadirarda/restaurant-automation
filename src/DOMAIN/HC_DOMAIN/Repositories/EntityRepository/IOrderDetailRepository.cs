﻿using HC_DOMAIN.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_DOMAIN.Repositories.EntityRepository
{
    public interface IOrderDetailRepository: IGenericRepository<OrderDetail>
    {
        Task<OrderDetail> GetOrderDetailById(Guid id);
        Task<List<OrderDetail>> GetOrderDetailsByOrderId(Guid orderId);
        Task<List<OrderDetail>> GetAllOrderDetails();
    }
}
