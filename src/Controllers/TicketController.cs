
using FinTrack_API.src.Model;

namespace FinTrack_API.src.Controllers
{
    public class TicketController : ITicketController
    {
        private static readonly TicketDTO ticketDTO = new();
        private static readonly Ticket ticket = new();

        // CRUD
        public void GetAllTickets() {}
        public void GetTicket() { }
        public void CreateTicket() { }
        public void UpdateTicket() { }
        public void DeleteTicket() { }
    }
}