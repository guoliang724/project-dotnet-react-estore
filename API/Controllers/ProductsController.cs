using API.Controllers;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API
{
    [ApiController]
    [Route("api/[controller]")]
    public class Products : BaseApiController
    {

        private readonly StoreContext _storeContext;
        public Products(StoreContext storeContext)
        {
            _storeContext = storeContext;

        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {

            return await _storeContext.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {

            var product = await _storeContext.Products.FindAsync(id);

            if (product == null) return NotFound(new ProblemDetails { Title = "No such product" });
            return product;
        }
    }
}