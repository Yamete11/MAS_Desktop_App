using MAS_BE.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderDTO>> GetOrders();
    }
}
