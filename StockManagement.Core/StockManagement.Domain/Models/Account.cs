namespace StockManagement.Domain.Models;

public sealed class Account : BaseEntity
{
    public string Name { get; }
    
    public decimal Balance { get; }
}