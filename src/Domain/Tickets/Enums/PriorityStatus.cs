using Ardalis.SmartEnum;

namespace Domain.Tickets.Enums;

public class PriorityStatus : SmartEnum<PriorityStatus>
{
    public static readonly PriorityStatus Low = new PriorityStatus(nameof(Low), 0);
    public static readonly PriorityStatus Medium = new PriorityStatus(nameof(Medium), 1);
    public static readonly PriorityStatus High = new PriorityStatus(nameof(High), 2);
    
    protected PriorityStatus(string name, int value) : base(name, value){ }
}