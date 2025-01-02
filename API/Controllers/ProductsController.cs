using System.Text.Json;
using API.Controllers;
using API.Data;
using API.Entities;
using API.Extensions;
using API.RequestHelpers;
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
        public async Task<ActionResult<PagedList<Product>>> GetProducts([FromQuery] ProductParams productParams)
        {
            var query = _storeContext.Products
            .Sort(productParams.OrderBy)
            .Search(productParams.Search)
            .Filter(productParams.Brands, productParams.Types)
            .AsQueryable();

            var products = await PagedList<Product>.ToPagedList(query, productParams.PageNumber, productParams.PageSize);

            Response.AddPaginationHeader(products.MetaData);

            return products;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {

            var product = await _storeContext.Products.FindAsync(id);

            if (product == null) return NotFound(new ProblemDetails { Title = "No such product" });
            return product;
        }


        [HttpGet("filters")]
        public async Task<IActionResult> GetFilters()
        {
            var brands = await _storeContext.Products.Select(p => p.Brand).Distinct().ToListAsync();
            var types = await _storeContext.Products.Select(p => p.Type).Distinct().ToListAsync();

            return Ok(new
            {
                Brands = brands,
                Types = types
            });
        }
    }
}