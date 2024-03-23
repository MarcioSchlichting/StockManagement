namespace StockManagement.Domain.Models;

public enum TransactionType
{
    Buy,
    Sell
}

public sealed class Transactions : BaseEntity
{
    public TransactionType Type { get; }
    
    public Stock Stock { get; }
    
    public int Quantity { get; }
    
    public decimal Price { get; }
}