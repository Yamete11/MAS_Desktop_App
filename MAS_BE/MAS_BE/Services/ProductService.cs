using MAS_BE.Context;
using MAS_BE.DTOs;
using MAS_BE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public class ProductService : IProductService
    {

        private readonly MyDbContext _context;

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

        public async Task<MethodResultDTO> PostProduct(ProductDTO productDTO)
        {
            IDbContextTransaction transaction = await _context.Database.BeginTransactionAsync();

            Product productToCheck = _context.Products.SingleOrDefault(x => x.Title.Trim().ToLower() == productDTO.Title.Trim().ToLower());

            if (productToCheck != null)
            {
                transaction.Rollback();

                return new MethodResultDTO
                {
                    HttpStatusCode = HttpStatusCode.NotFound,
                    Message = "Product already exists"
                };
            }


            Product product = new Product()
            {
                Title = productDTO.Title,
                Price = productDTO.Price,
                IdProductCategory = productDTO.IdProductCategory
            };

            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();

            await transaction.CommitAsync();

            return new MethodResultDTO
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = "Added"
            };
        }
    }
}
