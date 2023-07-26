using MAS_BE.DTOs;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public interface IReceiptService
    {
        public Task<MethodResultDTO> PostReceipt(ReceiptDTO receiptDTO);
    }
}
