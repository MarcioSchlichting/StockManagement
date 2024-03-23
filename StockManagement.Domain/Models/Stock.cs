namespace StockManagement.Domain.Models;

public sealed class Stock : BaseEntity
{
    public string Name { get; }
    
    public string Description { get; }
    
    public int Quantity { get; }
    
    public decimal Price { get; }
}