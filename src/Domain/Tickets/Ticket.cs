using Domain.Common;

namespace Domain.Tickets;

public class Ticket : BaseAuditableEntity<TicketId>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public DateTime CreationTime { get; set; }
    public string AssignedStaff { get; set; }
    public string Category { get; set; }
}