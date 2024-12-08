
using FakeDatabase.Models;

namespace FakeDatabase.Display;

public class DisplayCustomerInformation
{
    public static void ShowAllCustomers(List<Customer> myCustomers)
    {
        foreach (Customer customer in myCustomers)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(customer.GetFullName());
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var order in customer.Orders)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ordernummer: " + order.OrderId);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Datum: " + order.OrderDate);

                foreach (var product in order.Items)
                {
                    Console.WriteLine("ProduktId: " + product.ProductId);
                    Console.WriteLine("ProduktId: " + product.ProductName);
                }

                Console.WriteLine("Total sum: " + order.CalculateTotal() + " kr");
                Console.WriteLine("Date to pay: " + order.Invoice.DueDate);
                
            }
            Console.WriteLine("======================================");


        }

    }
    public static void FilterSearch(List<Customer> myCustomers)
    {
        foreach(Customer customer in myCustomers)
        {
            Console.WriteLine("Filter:"+customer.FirstName);
        }
    }
    public static void FindFirstCustomer(Customer customer)
    {
        if (customer != null)
        {
            Console.WriteLine($"First customer: {customer.FirstName}, {customer.LastName}");
        }
        else
        {
            Console.WriteLine("No customer found.");
        }
    }
    public static void Invoices(bool invoice)
    {
        if(invoice != true)
        {
            Console.WriteLine("Invoices: All invoices are not paid");
        }
        else
        {
            Console.WriteLine("Invoices: All invoices are paid!");
        }
    }


}
