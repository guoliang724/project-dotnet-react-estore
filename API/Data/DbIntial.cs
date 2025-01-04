
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class DbIntial
    {
        public static void Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (context.Products.Any())
                return;
        }
    }
}
