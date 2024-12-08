namespace FakeDatabase.Models;

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; }

    //a order can have many products (not nullable)
    // One to many!
    public List<Product> Items { get; set; } = new List<Product>();

    //A order can have one invoice(not nullable)
    // One to many!
    public Invoice Invoice { get; set; }
    public decimal CalculateTotal()
    {
        return Items.Sum(item => item.Price * item.Quantity);
    }
}
