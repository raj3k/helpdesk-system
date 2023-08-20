using Ardalis.SmartEnum;

namespace Domain.Tickets.Enums;

public class TicketStatus : SmartEnum<PriorityStatus>
{
    public static readonly TicketStatus Open = new TicketStatus(nameof(Open), 0);
    public static readonly TicketStatus InProgress = new TicketStatus(nameof(InProgress), 1);
    public static readonly TicketStatus Completed = new TicketStatus(nameof(Completed), 2);
    
    protected TicketStatus(string name, int value) : base(name, value) { }
}