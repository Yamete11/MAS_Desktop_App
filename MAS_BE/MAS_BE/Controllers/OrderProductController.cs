using MAS_BE.DTOs;
using MAS_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAS_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderProductController : ControllerBase
    {
        readonly IOrderProductService _service;

        public OrderProductController(IOrderProductService service)
        {
            _service = service;
        }

        [HttpGet("{IdOrder}")]
        public async Task<IEnumerable<OrderProductDTO>> GetProducts(int IdOrder)
        {
            return await _service.GetOrderProducts(IdOrder);
        }

        [HttpPut]
        public async Task<MethodResultDTO> UpdateOrderProduct(ProductResultDTO productResultDTOs)
        {
            return await _service.UpdateOrderProduct(productResultDTOs);
        }
    }
}
