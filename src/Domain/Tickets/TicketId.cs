using Domain.Common;

namespace Domain.Tickets;

public class TicketId : TypedIdValueBase
{
    public TicketId(Guid value) : base(value)
    {
    }
}