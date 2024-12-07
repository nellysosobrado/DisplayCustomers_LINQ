using FakeDatabase.Models;

namespace FakeDatabase.Data;

public class ApplicationDbContext_FAKE
{
    // Dessa motsvarar DbSet<T> i EF-Core
    // Varje klass motsvarar en Entitet (tabell) i SQL Databasen!
    public List<Customer> Customers { get; set; }
    public Order Orders { get; set; }
    public Product Items { get; set; }
    public Invoice Invoices { get; set; }
}
