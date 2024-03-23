namespace StockManagement.Domain.Models;

public sealed class User : BaseEntity
{
    public string Username { get; }
    
    public string Email { get; }
    
    public string Password { get; }
    
    public List<Stock> Stocks { get; }
    
    
}