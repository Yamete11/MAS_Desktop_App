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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            return await _service.GetOrders();
        }

        [HttpPost("CreateOrder")]
        public async Task<MethodResultDTO> PostOrder(NewOrderDTO orderDTO)
        {
            return await _service.PostOrder(orderDTO);
        }

        [HttpPost("CreateReceipt")]
        public async Task<MethodResultDTO> PostReceipt(ReceiptDTO receiptDTO)
        {
            return await _service.PostReceipt(receiptDTO);
        }
    }
}
