using MAS_BE.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<MethodResultDTO> DeleteProduct(int IdProduct);

        public Task<MethodResultDTO> PostProduct(ProductDTO productDTO);
    }
}
