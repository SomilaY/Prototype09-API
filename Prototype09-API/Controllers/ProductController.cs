using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype09_API.Models;

namespace Prototype09_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("Product")]
        public string ProductName()
        {
            return "Milk";
        }
        [HttpGet]
        [Route("All")]
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product> {
         new Product(1,"Coke"),
         new Product(2, "Meat"),
         new Product(3, "Coffee"),
         new Product(4, "Porridge"),
         };
        }
    }
}
