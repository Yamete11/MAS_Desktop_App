using MAS_BE.Context;
using MAS_BE.DTOs;
using MAS_BE.Entities;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public class ReceiptService : IReceiptService
    {

        private readonly MyDbContext _context;

        public ReceiptService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<MethodResultDTO> PostReceipt(ReceiptDTO receiptDTO)
        {

            Order order = _context.Orders.FirstOrDefault(o => o.IdOrder == receiptDTO.IdOrder);

            Receipt receipt = new Receipt
            {
                createdAt = DateTime.Now,
                NIP = receiptDTO.NIP,
                PaymentMethod = (PaymentMethod)receiptDTO.PaymentMethod,
                Sum = order.Sum
            };

            order.Receipt = receipt;
            order.ClosedAt = DateTime.Now;

            _context.Receipts.Add(receipt);

            _context.Orders.Update(order);

            await _context.SaveChangesAsync();

            return new MethodResultDTO
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = "Added"
            };
        }
    }
}
