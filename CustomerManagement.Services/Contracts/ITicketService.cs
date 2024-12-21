using CustomerManagement.Data.Entities;

namespace CustomerManagement.Services.Contracts
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetTicketsByUserIdAsync(int userId);
        Task<IEnumerable<Ticket>> GetTicketsByStatusAsync(string status);
        Task AddTicketAsync(Ticket ticket);
        Task UpdateTicketAsync(Ticket ticket);
        Task DeleteTicketAsync(int id);
    }
}
