using Domain.Common;

namespace Domain.Tickets.Events;

public class TicketCreatedEvent : BaseEvent
{
    public TicketCreatedEvent(Ticket ticket)
    {
        Ticket = ticket;
    }

    public Ticket Ticket { get; }
}