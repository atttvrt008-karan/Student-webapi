using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
      
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Milo" },
            new Product { Id = 2, Name = "Tim Tams" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_products);
        }

        [HttpPost("{rollno}")]
        public IActionResult GetById(int rollno)
        {
            var product = _products.Find(x => x.Id == rollno);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}