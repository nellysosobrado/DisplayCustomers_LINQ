using FakeDatabase.Data;
using FakeDatabase.Display;
using FakeDatabase.Models;

namespace FakeDatabase;

public class App
{
    public static void Run()
    {
       //Connection to the fake databse
        var dataInitializer = new DataInitializer();
        var DbContext = dataInitializer.MigrateAndSeedData();

        //Connection to customers in the database
        var myCustomers = DbContext.Customers;

        // Visa info kring mina nya kunder
        DisplayCustomerInformation.ShowAllCustomers(myCustomers);

        //Exercise: Display customer named 'Anna'
        var allAnnaCustomer = DbContext.Customers.Where(x => x.FirstName == "Anna").ToList();
        DisplayCustomerInformation.FilterSearch(allAnnaCustomer);

        //Exercise: Display first customer named 'Anna'
        var SearchAnna = DbContext.Customers.FirstOrDefault(x => x.FirstName == "Anna");
        DisplayCustomerInformation.FindFirstCustomer(SearchAnna);

        //Exercise: Display all paid invoices
        bool allPaid = myCustomers.All(c => c.Orders.All(o => o.Invoice.IsPaid));
        DisplayCustomerInformation.Invoices(allPaid);

   
        

    }
}
