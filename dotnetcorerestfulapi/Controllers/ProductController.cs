using System.Collections.Generic;
using dotnetcorerestfulapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcorerestfulapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> _products;

        public ProductController()
        {
            _products = new List<Product>();
            if(_products.Count == 0){
                _products.Add(new Product(){
                    ProductId = 1,
                    ProductName = "Hello dotnet core!",
                    ProductCode = "123456"
                });
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _products;
        }

    }
}