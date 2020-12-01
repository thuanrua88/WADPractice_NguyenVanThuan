using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.service;
using Practice.Models;

namespace Practice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(JsonFileProduct productService)
        {
            this.ProductSevice = productService;
        }

        public JsonFileProduct ProductSevice { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductSevice.GetProducts();
        }

    }
}
