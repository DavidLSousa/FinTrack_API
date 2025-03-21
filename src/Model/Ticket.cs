
namespace FinTrack_API.src.Model
{
    public class Ticket
    {
        public string NameTicket { get; set; }
        public string TicketCode { get; set; }
        public Guid Id { get; private set; }
        public List<Dictionary<string, object>> History { get; set; }

        private int _numberOfTickets;
        private double _totalValuePurchased;
        private double _highestPrice;
        private double _lowestPrice;
        private double _averagePrice;

        public Ticket()
        {
            Id = Guid.NewGuid();
            History = [];
            NameTicket = string.Empty;
            TicketCode = string.Empty;
        }

        public int NumberOfTickets
        {
            get => _numberOfTickets;
            set
            {
                if (value > 0)
                    _numberOfTickets = value;
                else
                    throw new ArgumentException("O número de tickets deve ser maior que 0");
            }
        }

        public double TotalValuePurchased
        {
            get => _totalValuePurchased;
            set
            {
                if (value > 0)
                    _totalValuePurchased = value;
                else
                    throw new ArgumentException("O valor total de compra deve ser maior que 0");
            }
        }

        public double HighestPrice
        {
            get => _highestPrice;
            set
            {
                if (value > 0)
                    _highestPrice = value;
                else
                    throw new ArgumentException("O valor de compra deve ser maior que 0");
            }
        }

        public double LowestPrice
        {
            get => _lowestPrice;
            set
            {
                if (value > 0)
                    _lowestPrice = value;
                else
                    throw new ArgumentException("O valor de compra deve ser maior que 0");
            }
        }

        public double AveragePrice
        {
            get => _averagePrice;
            set
            {
                if (value > 0)
                    _averagePrice = value;
                else
                    throw new ArgumentException("O valor de compra deve ser maior que 0");
            }
        }
    }
}
