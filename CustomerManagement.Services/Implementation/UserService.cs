using CustomerManagement.Common.Models;
using CustomerManagement.Repository.Interfaces;
using CustomerManagement.Services.Contracts;

namespace CustomerManagement.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task AddUserAsync(UserViewModel user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(UserViewModel user)
        {
            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserViewModel>> GetUsersWithRolesAsync()
        {
            return await _userRepository.GetUsersWithRolesAsync();
        }

        public List<RoleViewModel> GetAllRoles()
        {
            return _userRepository.GetAllRoles();
        }
    }
}
