using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly XContext _xContext;
        public OrderRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
