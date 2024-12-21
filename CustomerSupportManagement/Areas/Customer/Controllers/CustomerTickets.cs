using Microsoft.AspNetCore.Mvc;

namespace CustomerSupportManagement.Areas.Customer.Controllers
{
    public class CustomerTickets : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
