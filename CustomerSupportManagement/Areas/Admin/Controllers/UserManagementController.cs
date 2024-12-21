using CustomerManagement.Common.Models;
using CustomerManagement.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerSupportManagement.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserManagementController : Controller
    {
        private readonly IUserService _userService;

        public UserManagementController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var users = _userService.GetUsersWithRolesAsync();
            return View(users);
        }

        /*public IActionResult Details(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null) return NotFound();
            return View(user);
        }*/

        public JsonResult GetRoles()
        {
            List<RoleViewModel> roles = _userService.GetAllRoles();
            return Json(roles);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUserAsync(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        /*public IActionResult Edit(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction("Index");
        }*/

    }
}
