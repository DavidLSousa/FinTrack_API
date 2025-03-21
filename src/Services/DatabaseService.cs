
using FinTrack_API.src.Model;
using FinTrack_API.src.Repositories;

namespace FinTrack_API.src.Services
{
    public class DatabaseService
    {
        private readonly IDatabaseRepository _repository;
        Task<Ticket?> GetTicket(string ticketName) 
        {
            return _repository.GetTicket(ticketName);
        }
        Task<List<Ticket>> GetAllTickets() 
        {
            return _repository.GetAllTickets();
        }
        Task CreateTicket(Ticket ticket) 
        {
            return _repository.CreateTicket(ticket);
        }
        Task UpdateTicketSale(Ticket dataUpdated) 
        {
            return _repository.UpdateTicketSale(dataUpdated);
        }
        Task UpdateTicketIncrement(Ticket ticket) 
        {
            return _repository.UpdateTicketIncrement(ticket);
        }
        Task DeleteTicket(string ticketName) 
        {
            return _repository.DeleteTicket(ticketName);
        }
    }
}