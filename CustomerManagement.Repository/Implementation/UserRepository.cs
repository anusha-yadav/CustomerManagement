using CustomerManagement.Common.Models;
using CustomerManagement.Data;
using CustomerManagement.Data.Entities;
using CustomerManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace CustomerManagement.Repository.Implementation
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ManagementContext _managementContext;
        public UserRepository(ManagementContext context) : base(context) 
        {
            _managementContext = context;
        }

        public async Task<IEnumerable<UserViewModel>> GetUsersWithRolesAsync()
        {
            return (IEnumerable<UserViewModel>)await _managementContext.Users.Include(u => u.Role).ToListAsync();
        }

        public async Task<UserViewModel> GetByIdAsync(int id)
        {
            var user = await _managementContext.Users.FindAsync(id);
            UserViewModel userDetails = new()
            {
                UserId = user.UserId,
                RoleId = user.RoleId,
                Name = user.Name
            };
            return userDetails;
        }

        public async Task AddAsync(UserViewModel user)
        {
            await _managementContext.AddAsync(user);
            await _managementContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserViewModel user)
        {
            var existingUser = await _managementContext.Users.FindAsync(user.UserId);
            if (existingUser != null)
            {
                _managementContext.Entry(existingUser).CurrentValues.SetValues(user);
                await _managementContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _managementContext.Users.FindAsync(id);
            if (user != null)
            {
                _managementContext.Users.Remove(user);
                await _managementContext.SaveChangesAsync();
            }
        }

        public List<RoleViewModel> GetAllRoles()
        {
            return _managementContext.Roles.Select(vm => new RoleViewModel
            {
                RoleId = vm.RoleId,
                RoleName = vm.RoleName,
            }).ToList();
        }
    }
}
