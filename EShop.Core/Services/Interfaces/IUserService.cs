
using EShop.Data.Entities;

namespace EShop.Core.Services.Interfaces
{
    public interface IUserService
    {
        public Task<bool> IsExistEmail(string email);
        public Task<bool> IsExistUserName(string userName);
        public Task<int> AddUser(User user);
    }
}
