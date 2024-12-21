using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerManagement.Common.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
        public List<SelectListItem> Roles { get; set; }

    }
}
