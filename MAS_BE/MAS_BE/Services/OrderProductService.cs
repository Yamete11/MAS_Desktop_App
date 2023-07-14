using MAS_BE.Context;
using MAS_BE.DTOs;
using MAS_BE.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public class OrderProductService : IOrderProductService
    {

        readonly MyDbContext _context;

        public OrderProductService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<OrderProductDTO>> GetOrderProducts(int IdOrder)
        {
            return await _context.OrderProducts
                .Where(orderProduct => orderProduct.IdOrder == IdOrder)
                .Join(_context.Products,
                orderProduct => orderProduct.IdProduct,
                product => product.IdProduct,
                (orderProduct, product) => new OrderProductDTO
                {
                    IdOrderProduct = orderProduct.IdOrderProduct,
                    Title = product.Title,
                    IdOrder = orderProduct.IdOrder,
                    IdProduct = product.IdProduct,
                    Price = product.Price
                })
            .ToListAsync();
        }

        public async Task<MethodResultDTO> UpdateOrderProduct(List<ProductResultDTO> productResultDTOs)
        {
            var orderProductsToUpdate = await _context.OrderProducts
                .Where(op => op.IdOrder == productResultDTOs[0].IdOrder)
                .ToListAsync();

            
            _context.OrderProducts.RemoveRange(orderProductsToUpdate);




            var newOrderProducts = productResultDTOs.Select(dto => new OrderProduct
            {
                IdProduct = dto.IdProduct,
                IdOrder = dto.IdOrder
            }).ToList();

            
            
            _context.OrderProducts.AddRange(newOrderProducts);
            await _context.SaveChangesAsync();

            float totalPrice = (from p in _context.Products
                                join op in _context.OrderProducts on p.IdProduct equals op.IdProduct
                                where op.IdOrder == productResultDTOs[0].IdOrder
                                select p.Price).Sum();

            var orderToUpdate = _context.Orders.FirstOrDefault(op => op.IdOrder == productResultDTOs[0].IdOrder);

            orderToUpdate.Sum = totalPrice;

            _context.Orders.Update(orderToUpdate);


            await _context.SaveChangesAsync();

            return new MethodResultDTO
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = "Updated"
            }; ;
        }

    }
}
