
using FinTrack_API.src.Model;

namespace FinTrack_API.src.Repositories
{
    public class MariaDBRepository : IDatabaseRepository
    {
        public Task<Ticket?> GetTicket(string ticketName) 
        {
            return Task.FromResult<Ticket?>(null);
        }
        public Task<List<Ticket>> GetAllTickets() 
        {
            return Task.FromResult<List<Ticket>>(null);
        }
        public Task CreateTicket(Ticket ticket) 
        {
            return Task.CompletedTask;
        }
        public Task UpdateTicketSale(Ticket dataUpdated) 
        {
            return Task.CompletedTask;
        }
        public Task UpdateTicketIncrement(Ticket ticket) 
        {
            return Task.CompletedTask;
        }
        public Task DeleteTicket(string ticketName) 
        {
            return Task.CompletedTask;
        }
    }
}