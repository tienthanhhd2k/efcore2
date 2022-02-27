using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using efcore2.Models;
using efcore2.Services;

namespace efcore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _iProduct;
        public ProductController(IProduct iProduct)
        {
            _iProduct = iProduct;
        }
        [HttpGet("Get Product")]
        public List<Product> GetProducts()
        {
            return _iProduct.GetProducts();
        }
        [HttpPost]
        public HttpStatusCode Create(Product pro)
        {
            _iProduct.CreateProduct(pro);
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Update(Product pro)
        {
            _iProduct.UpdateProduct(pro);
            return HttpStatusCode.OK;
        }
        [HttpDelete]
        public HttpStatusCode Detele(int id)
        {
            _iProduct.DeleteProduct(id);
            return HttpStatusCode.OK;
        }
    }
}