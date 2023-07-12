using MAS_BE.Context;
using MAS_BE.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public class OrderService : IOrderService
    {

        readonly MyDbContext _context;

        public OrderService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            return await _context.Orders.Select(x => new OrderDTO
            {
                IdOrder = x.IdOrder,
                Sum = x.Sum,
                CreateAt = x.CreateAt
            }).ToListAsync();
        }
    }
}
