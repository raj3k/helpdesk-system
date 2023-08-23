using Ardalis.GuardClauses;
using Domain.Common;

namespace Domain.Tickets;

public class Category : ValueObject
{
    
    public string Name { get; set; }

    public Category(string name)
    {
        Name = Guard.Against.NullOrEmpty(name);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
    }
}