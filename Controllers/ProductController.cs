using ApiFirst.Data.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        //private static List<Product> Products = new List<Product>() {
        //    new Product { Id = 1, Name = "Product1", Price=60 },
        //    new Product { Id = 2, Name = "Product2", Price=6 },
        //    new Product { Id = 3, Name = "Product3", Price=69 },
        //    new Product { Id = 4, Name = "Product4", Price=96 }
        //};

        //[Route("all")]
        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(200,_context.Produ);
        }

        //[Route("one")]
        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            Product product = Products.FirstOrDefault(product => product.Id == id);
            if (product == null) return NotFound();
            return StatusCode(200, Products.FirstOrDefault(p=>p.Id==id));
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            Products.Add(product);
            return StatusCode(201, product);
        }
    }
}
