﻿using MAS_BE.DTOs;
using MAS_BE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAS_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            return await _service.GetProducts();
        }

        [HttpDelete("{IdProduct}")]
        public async Task<MethodResultDTO> DeleteProduct(int IdProduct)
        {
            return await _service.DeleteProduct(IdProduct);
        }

        [HttpPost]
        public async Task<MethodResultDTO> PostProduct(ProductDTO productDTO)
        {
            return await _service.PostProduct(productDTO);
        }
    }
}
