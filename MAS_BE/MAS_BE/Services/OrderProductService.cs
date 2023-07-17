using MAS_BE.Context;
using MAS_BE.DTOs;
using MAS_BE.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MAS_BE.Services
{
    public class OrderProductService : IOrderProductService
    {

        private readonly MyDbContext _context;

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

        public async Task<MethodResultDTO> UpdateOrderProduct(ProductResultDTO productResultDTOs)
        {
            
            var orderProductsToUpdate = await _context.OrderProducts
                .Where(op => op.IdOrder == productResultDTOs.IdOrder)
                .ToListAsync();

            
            _context.OrderProducts.RemoveRange(orderProductsToUpdate);

            foreach(var productId in productResultDTOs.IdProducts)
            {
                OrderProduct orderProduct = new OrderProduct
                {
                    IdProduct = productId,
                    IdOrder = productResultDTOs.IdOrder,
                    CreateAt = DateTime.Now
                };

                _context.OrderProducts.Add(orderProduct);
            }

            float totalPrice = (from p in productResultDTOs.IdProducts
                                join op in _context.Products on p equals op.IdProduct
                                select op.Price).Sum();

            var orderToUpdate = _context.Orders.FirstOrDefault(op => op.IdOrder == productResultDTOs.IdOrder);

            orderToUpdate.Sum = totalPrice;

            _context.Orders.Update(orderToUpdate);


            await _context.SaveChangesAsync();



            return new MethodResultDTO
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = "Updated"
            };
        }

    }
}
