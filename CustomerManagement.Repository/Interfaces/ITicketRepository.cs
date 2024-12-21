using CustomerManagement.Data.Entities;

namespace CustomerManagement.Repository.Interfaces
{

    public interface ITicketRepository : IBaseRepository<Ticket>
    {
        Task<IEnumerable<Ticket>> GetTicketsByUserIdAsync(int userId);
        Task<IEnumerable<Ticket>> GetTicketsByStatusAsync(string status);
    }
}
