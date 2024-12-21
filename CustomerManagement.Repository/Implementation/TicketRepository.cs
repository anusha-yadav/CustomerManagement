using CustomerManagement.Data;
using CustomerManagement.Data.Entities;
using CustomerManagement.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.Repository.Implementation
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        private readonly ManagementContext _managementContext;
        public TicketRepository(ManagementContext context) : base(context)
        {
            _managementContext = context;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByUserIdAsync(int userId)
        {
            return await _managementContext.Tickets.Where(t => t.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByStatusAsync(string status)
        {
            return await _managementContext.Tickets.Where(t => t.Status == status).ToListAsync();
        }
    }
}
