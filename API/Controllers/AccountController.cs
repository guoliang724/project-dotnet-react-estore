using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
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
            if (user == null || !await _userManager.CheckPasswordAsync(user, loginDto.Password))
                return Unauthorized();

            var userBasket = await RetrieveBasket(loginDto.Username);
            var nonBasket = await RetrieveBasket(Request.Cookies["buyerId"]);

            if (nonBasket != null)
            {
                if (userBasket != null) _context.Baskets.Remove(userBasket);
                nonBasket.BuyerId = user.UserName;
                Response.Cookies.Delete("buyerId");
                await _context.SaveChangesAsync();
            }

            var basket = nonBasket != null ? nonBasket.MapBasketToDto() : userBasket != null ? userBasket.MapBasketToDto() : null;

            return new UserDto
            {
                Token = await _tokenService.GenerateToken(user),
                Email = user.Email,
                basketDto = basket
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

            if (nonBasket != null)
            {
                if (userBasket != null) _context.Baskets.Remove(userBasket);
                nonBasket.BuyerId = user.UserName;
                Response.Cookies.Delete("buyerId");
                await _context.SaveChangesAsync();
            }

            var basket = nonBasket != null ? nonBasket.MapBasketToDto() : userBasket != null ? userBasket.MapBasketToDto() : null;
            return new UserDto
            {
                Token = await _tokenService.GenerateToken(user),
                Email = user.Email,
                basketDto = basket,
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

        [Authorize]
        [HttpGet("savedAddress")]
        public async Task<ActionResult<UserAddress>> GetSavedAddress()
        {
            return await _userManager.Users.Where(x => x.UserName == User.Identity.Name)
            .Select(user => user.Address).FirstOrDefaultAsync();
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


    }
}