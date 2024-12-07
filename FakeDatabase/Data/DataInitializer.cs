
using FakeDatabase.Models;

namespace FakeDatabase.Data;

internal class DataInitializer
{
    // Skapa en connection till vår fake Databas
    private ApplicationDbContext_FAKE _dbContext;
    public ApplicationDbContext_FAKE MigrateAndSeedData()
    {
        _dbContext = new ApplicationDbContext_FAKE();
        _dbContext.Customers = new List<Customer>();
        SeedCustomers();

        return _dbContext;
    }

    private ApplicationDbContext_FAKE SeedCustomers()
    {
        // Create a Customer
        var customer = new Customer
        {
            CustomerId = 1,
            FirstName = "Anna",
            LastName = "Svensson",
            Email = "anna.svensson@example.com",
            PhoneNumber = "0701234567",
            DateOfBirth = new DateTime(1985, 4, 12),
            Address = "Storgatan 10, 111 22 Stockholm",
            Orders = new List<Order>
                {
                    new Order
                    {
                        OrderId = 1,
                        CustomerId = 1,
                        OrderDate = DateTime.Now.AddDays(-7),
                        Items = new List<Product>
                        {
                            new Product { ProductId = 1, ProductName = "Bok", Price = 100, Quantity = 2 },
                            new Product { ProductId = 2, ProductName = "Penna", Price = 10, Quantity = 5 }
                        },
                        Invoice = new Invoice { InvoiceId = 1, Amount = 100*2 + 10*5 }
                    },
                    new Order
                    {
                        OrderId = 2,
                        CustomerId = 1,
                        OrderDate = DateTime.Now.AddDays(-2),
                        Items = new List<Product>
                        {
                            new Product { ProductId = 3, ProductName = "Dator", Price = 10000, Quantity = 1 },
                            new Product { ProductId = 4, ProductName = "Tangentbord", Price = 300, Quantity = 1 }
                        },
                        Invoice = new Invoice { InvoiceId = 2, Amount = 10000 + 300 }
                    }
                }
        };

        // Lägg till vår nya kund i databasen
        _dbContext.Customers.Add(customer);

        // Create a second Customer
        var customer2 = new Customer
        {
            CustomerId = 2,
            FirstName = "Erik",
            LastName = "Johansson",
            Email = "erik.johansson@example.com",
            PhoneNumber = "0707654321",
            DateOfBirth = new DateTime(1990, 8, 23),
            Address = "Långgatan 20, 111 33 Stockholm",
            Orders = new List<Order>
            {
                new Order
                {
                    OrderId = 3,
                    CustomerId = 2,
                    OrderDate = DateTime.Now.AddDays(-10),
                    Items = new List<Product>
                    {
                        new Product { ProductId = 5, ProductName = "Hörlurar", Price = 200, Quantity = 2 },
                        new Product { ProductId = 6, ProductName = "Mobilskal", Price = 150, Quantity = 1 }
                    },
                    Invoice = new Invoice { InvoiceId = 3, Amount = 200*2 + 150 }
                },
                new Order
                {
                    OrderId = 4,
                    CustomerId = 2,
                    OrderDate = DateTime.Now.AddDays(-1),
                    Items = new List<Product>
                    {
                        new Product { ProductId = 7, ProductName = "Mössa", Price = 80, Quantity = 3 },
                        new Product { ProductId = 8, ProductName = "Halsduk", Price = 120, Quantity = 1 }
                    },
                    Invoice = new Invoice { InvoiceId = 4, Amount = 80*3 + 120 }
                }
            }
        };

        // Lägg till vår andra nya kund i databasen
        _dbContext.Customers.Add(customer2);
        return _dbContext;
    }
}
