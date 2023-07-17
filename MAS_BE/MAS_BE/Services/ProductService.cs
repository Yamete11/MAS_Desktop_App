using MAS_BE.Context;
using MAS_BE.DTOs;
using MAS_BE.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public class ProductService : IProductService
    {

        readonly MyDbContext _context;

        public ProductService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<MethodResultDTO> DeleteProduct(int IdProduct)
        {
            Product product = _context.Products.SingleOrDefault(x => x.IdProduct == IdProduct);

            var list = _context.OrderProducts.Where(x => x.IdProduct == IdProduct).ToList();

            foreach (var orderProduct in list)
            {
                _context.OrderProducts.Remove(orderProduct);
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return new MethodResultDTO
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = "Deleted"
            };
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            return await _context.Products.Select(x => new ProductDTO
            {
                IdProduct = x.IdProduct,
                Title = x.Title,
                Price = x.Price,
                IdProductCategory = x.IdProductCategory
            }).ToListAsync();
        }
    }
}
