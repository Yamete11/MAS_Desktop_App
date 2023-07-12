using MAS_BE.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public interface IOrderProductService
    {
        public Task<IEnumerable<OrderProductDTO>> GetOrderProducts(int IdOrder);
        public Task<MethodResultDTO> UpdateOrderProduct(List<ProductResultDTO> productResultDTOs);
    }
}
