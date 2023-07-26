using MAS_BE.DTOs;
using MAS_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MAS_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {

        private readonly IReceiptService _service;

        public ReceiptController(IReceiptService service)
        {
            _service = service;
        }


        [HttpPost]
        public async Task<MethodResultDTO> PostReceipt(ReceiptDTO receiptDTO)
        {
            return await _service.PostReceipt(receiptDTO);
        }
    }
}
