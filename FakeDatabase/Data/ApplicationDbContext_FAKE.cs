using FakeDatabase.Models;

namespace FakeDatabase.Data;

public class ApplicationDbContext_FAKE
{
    // Detta motsvarar ett DbSet<> i EF-Core
    public List<Customer> Customers { get; set; }
}
