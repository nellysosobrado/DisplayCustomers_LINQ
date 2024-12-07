namespace FakeDatabase.Models;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public string GetProductNameAndPrice()
    {
        return $"{ProductName} kostar {Price}";
    }
}