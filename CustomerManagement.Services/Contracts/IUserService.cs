using CustomerManagement.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Services.Contracts
{
    public interface IUserService
    {
        //Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        Task<UserViewModel> GetUserByIdAsync(int id);
        Task AddUserAsync(UserViewModel user);
        Task UpdateUserAsync(UserViewModel user);
        Task DeleteUserAsync(int id);
        Task<IEnumerable<UserViewModel>> GetUsersWithRolesAsync();
        List<RoleViewModel> GetAllRoles();
    }
}
