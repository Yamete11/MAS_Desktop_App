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
    public class OrderService : IOrderService
    {

        readonly MyDbContext _context;

        public OrderService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            return await _context.Orders.Select(x => new OrderDTO
            {
                IdOrder = x.IdOrder,
                Sum = x.Sum,
                CreateAt = x.CreateAt
            }).ToListAsync();
        }

        public async Task<MethodResultDTO> PostOrder(NewOrderDTO newOrderDTO)
        {

            float totalPrice = (from p in newOrderDTO.IdProducts
                                join op in _context.Products on p equals op.IdProduct
                                select op.Price).Sum();

            Order order = new Order
            {
                Sum = totalPrice,
                CreateAt = DateTime.Now,
                IdOrderType = newOrderDTO.IdOrderType,
                TableNumber = newOrderDTO.TableNumber
            };
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            var generatedOrderId = order.IdOrder;

            foreach (var productId in newOrderDTO.IdProducts)
            {
                OrderProduct orderProduct = new OrderProduct
                {
                    IdProduct = productId,
                    IdOrder = generatedOrderId,
                    CreateAt = DateTime.Now
                };

                _context.OrderProducts.Add(orderProduct);
            }

            await _context.SaveChangesAsync();


            return new MethodResultDTO
            {
                HttpStatusCode = HttpStatusCode.OK,
                Message = "Updated"
            };
        }
    }
}
