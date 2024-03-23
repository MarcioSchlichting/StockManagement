namespace StockManagement.Domain.Models;

public abstract class BaseEntity
{
    public Guid Id { get; }
    
    public DateTime CreatedAt { get; }
    
    public DateTime UpdatedAt { get; }
    
    public string CreatedBy { get; }
    
    public string UpdatedBy { get; }
}