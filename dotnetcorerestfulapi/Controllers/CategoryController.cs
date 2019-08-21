using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetcorerestfulapi.Models;

namespace dotnetcorerestfulapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private List<Category> _categories;
        public CategoryController()
        {
            _categories = new List<Category>();

            if(_categories.Count == 0){
                _categories.Add(new Category(){
                    CategoryId = 1,
                    CategoryName = "Computer",
                    Products = new List<Product>()
                });
            }
        }
         // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return _categories;
        }

    }
}