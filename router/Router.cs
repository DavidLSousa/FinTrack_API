
using FinTrack_API.src.Controllers;

namespace FinTrack_API.router
{
    public static class Router
    {
        private static readonly TicketController ticketController = new();
        
        public static void Map(WebApplication app)
        {
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/allTickets", () => ticketController.GetAllTickets);
            app.MapGet("/ticket/{id}", (int id) => ticketController.GetTicket);
            app.MapPost("/ticket", () => ticketController.CreateTicket);
            app.MapPut("/ticket/{id}", (int id) => ticketController.UpdateTicket);
            app.MapDelete("/ticket/{id}", (int id) => ticketController.DeleteTicket);
        }
    }
}