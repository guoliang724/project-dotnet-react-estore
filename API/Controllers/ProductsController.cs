using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API
{
    [ApiController]
    [Route("api/[controller]")]
    public class Products : ControllerBase
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

        [HttpGet("id")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {

            return await _storeContext.Products.FindAsync(id);
        }
    }
}