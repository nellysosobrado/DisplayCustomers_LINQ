namespace FakeDatabase.Models;

public class Invoice
{
    public int InvoiceId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsPaid { get; set; }

    public Invoice()
    {
        InvoiceDate = new DateTime();
        InvoiceDate = DateTime.Now;

        DueDate = new DateTime();
        DueDate = DateTime.Now.AddDays(30);
    }
}