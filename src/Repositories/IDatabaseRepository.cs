
using FinTrack_API.src.Model;

namespace FinTrack_API.src.Repositories
{
    public interface IDatabaseRepository
    {
        public Task<Ticket?> GetTicket(string ticketName);
        public Task<List<Ticket>> GetAllTickets();
        public Task CreateTicket(Ticket ticket);
        public Task UpdateTicketSale(Ticket dataUpdated);
        public Task UpdateTicketIncrement(Ticket ticket);
        public Task DeleteTicket(string ticketName);
    }
}