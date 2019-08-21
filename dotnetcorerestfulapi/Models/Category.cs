using System.Collections.Generic;

namespace dotnetcorerestfulapi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}