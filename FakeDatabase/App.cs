using FakeDatabase.Data;
using FakeDatabase.Display;
using FakeDatabase.Models;

namespace FakeDatabase;

public class App
{
    public static void Run()
    {
        // Skapa en connection till vår fake Databas
        var dataInitializer = new DataInitializer();
        var DbContext = dataInitializer.MigrateAndSeedData();

        // Skapa en connection till våra kunder i Databasen
        var myCustomers = DbContext.Customers;

        // Visa info kring mina nya kunder
        DisplayCustomerInformation.ShowAllCustomers(myCustomers);

        // Övning
        // fr1. Visa alla kunder som heter "Anna"
        var allAnnaCustomer = DbContext.Customers.Where(x => x.FirstName == "Anna").ToList();
        DisplayCustomerInformation.FilterSearch(allAnnaCustomer);


        // fr2. Visa den första kunde som heter "Anna"
        var SearchAnna = DbContext.Customers.FirstOrDefault(x => x.FirstName == "Anna");
        DisplayCustomerInformation.FindFirstCustomer(SearchAnna);


        // fr3. Är ALLA fakturor betalda? (svårare)
        bool allPaid = myCustomers.All(c => c.Orders.All(o => o.Invoice.IsPaid));
        DisplayCustomerInformation.Invoices(allPaid);

   
        

    }
}
