
namespace FinTrack_API.src.Controllers
{
    public interface ITicketController
    {
        public void GetAllTickets();
        public void GetTicket();
        public void CreateTicket();
        public void UpdateTicket();
        public void DeleteTicket();
    }
}