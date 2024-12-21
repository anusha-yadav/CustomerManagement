using CustomerManagement.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSupportManagement.Areas.SupportAgent.Controllers
{
    [Area("SupportAgent")]
    public class TicketsController : Controller
    {

        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        public IActionResult Index()
        {
            //var tickets = await _ticketService.GetTicketsByStatusAsync("Open");
            return View();
        }

    }
}
