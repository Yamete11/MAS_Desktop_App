using MAS_BE.Context;
using MAS_BE.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
