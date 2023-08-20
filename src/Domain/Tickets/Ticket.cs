using Ardalis.GuardClauses;
using Domain.Common;
using Domain.Tickets.Enums;

namespace Domain.Tickets;

public class Ticket : BaseAuditableEntity<TicketId>
{
    // TODO: Work on Ticket class. create enums, validation, VO etc.
    public string Title { get; set; }
    public string Description { get; set; }
    public TicketStatus Status { get; private set; } = TicketStatus.Open; 
    public PriorityStatus Priority { get; }
    public DateTime CreationTime { get; } = DateTime.Now;
    public string AssignedStaff { get; set; }
    public string Category { get; set; }

    public Ticket(string title, string description, PriorityStatus priorityStatus)
    {
        Title = Guard.Against.NullOrEmpty(title);
        Description = Guard.Against.NullOrEmpty(description);
        Priority = priorityStatus;
    }
}