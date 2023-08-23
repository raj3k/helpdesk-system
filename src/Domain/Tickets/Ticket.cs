using Ardalis.GuardClauses;
using Domain.Common;
using Domain.Tickets.Enums;

namespace Domain.Tickets;

public class Ticket : BaseAuditableEntity<TicketId>
{
    private string Title { get; }
    private string Description { get; }
    private TicketStatus Status { get; set; } = TicketStatus.Open; 
    private PriorityStatus Priority { get; }
    private string AssignedStaff { get; set; } = "TEST"; // placeholder
    private Category Category { get; }

    public Ticket(string title, string description, PriorityStatus priorityStatus, string category)
    {
        Title = Guard.Against.NullOrEmpty(title);
        Description = Guard.Against.NullOrEmpty(description);
        Priority = priorityStatus;
        Category = new Category(category);
    }

    private Ticket()
    {
    }

    public void UpdateTicketStatus(TicketStatus newStatus)
    {
        Status = Guard.Against.Null(newStatus);
    }
}