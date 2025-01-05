using API.Data;
using API.DTOs;
using API.Entities;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly UserManager<User> _userManager;
        private readonly TokenService _tokenService;
        private readonly StoreContext _context;
        public AccountController(UserManager<User> userManager, TokenService tokenService, StoreContext storeContext)
        {
            _context = storeContext;
            _tokenService = tokenService;
            _userManager = userManager;
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.Username);

            if (user == null) return Unauthorized("Invalid username");


            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);

            if (!result) return Unauthorized();

            var userBasket = await RetrieveBasket(loginDto.Username);
            var nonBasket = await RetrieveBasket(Request.Cookies["buyerId"]);

            if(nonBasket != null) {
                if(userBasket !=null) _context.Baskets.Remove(userBasket);
                nonBasket.BuyerId = user.UserName;
                Response.Cookies.Delete("buyerId");
                await _context.SaveChangesAsync();
            }
            
            var basket = nonBasket != null ?nonBasket:userBasket;

            return new UserDto
            {
                Token = await _tokenService.GenerateToken(user),
                Email = user.Email,
                basketDto = MapBasketToDto(basket),
            };
        }


        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {

            var user = new User
            {
                UserName = registerDto.Username,
                Email = registerDto.Email,
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }

            return ValidationProblem();
        }

            await _userManager.AddToRoleAsync(user, "Member");

             var userBasket = await RetrieveBasket(registerDto.Username);
            var nonBasket = await RetrieveBasket(Request.Cookies["buyerId"]);

            if(nonBasket != null) {
                if(userBasket !=null) _context.Baskets.Remove(userBasket);
                nonBasket.BuyerId = user.UserName;
                Response.Cookies.Delete("buyerId");
                await _context.SaveChangesAsync();
            }
            
            var basket = nonBasket != null ?nonBasket:userBasket;

            return new UserDto
            {
                Token = await _tokenService.GenerateToken(user),
                Email = user.Email,
                basketDto = MapBasketToDto(basket),
            };

        }


        [Authorize]
        [HttpGet("currentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            return new UserDto
            {
                Email = user.Email,
                Token = await _tokenService.GenerateToken(user)
            };
        }

          private async Task<Basket> RetrieveBasket(string buyerId)
        {
            if (string.IsNullOrEmpty(buyerId))
            {
                Response.Cookies.Delete("buyerId");
                return null;
            }
            var basket = await _context.Baskets
           .Include(i => i.Items)
           .ThenInclude(p => p.Product)
           .FirstOrDefaultAsync(x => x.BuyerId == buyerId);
            return basket;
        }

         private BasketDto MapBasketToDto(Basket basket)
        {
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(x => new BasketItemDto
                {
                    ProductId = x.
                    ProductId,
                    Name = x.Product.Name,
                    Price = x.Product.Price,
                    PictureUrl = x.Product.PictureUrl,
                    Type = x.Product.Type,
                    Brand = x.Product.Brand,
                    Quantity = x.Quantity,
                }).ToList()

            };
        }


    }
}