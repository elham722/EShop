
using EShop.Data.Context;

namespace EShop.Core.Services
{
    public class UserService(EShopDbContext context): IUserService
    {
        public async Task<bool> IsExistEmail(string email)
        {
           return await context.Users.AnyAsync(x => x.Email == email);
        }
        public async Task<bool> IsExistUserName(string userName)
        {
            return await context.Users.AnyAsync(x => x.UserName == userName);
        }
    }
    
}
