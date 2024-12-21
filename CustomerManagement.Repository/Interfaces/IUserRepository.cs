using CustomerManagement.Common.Models;
using CustomerManagement.Data.Entities;

namespace CustomerManagement.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserViewModel>> GetUsersWithRolesAsync();
        Task<UserViewModel> GetByIdAsync(int id);
        Task AddAsync(UserViewModel user);
        Task UpdateAsync(UserViewModel user);
        Task DeleteAsync(int id);
        List<RoleViewModel> GetAllRoles();
    }
}
