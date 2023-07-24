using MAS_BE.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderDTO>> GetOrders();

        public Task<MethodResultDTO> PostOrder(NewOrderDTO newOrderDTO);

        public Task<MethodResultDTO> PostReceipt(ReceiptDTO receiptDTO);
    }
}
