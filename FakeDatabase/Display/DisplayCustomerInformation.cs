
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

                Console.WriteLine("Total kostnad: " + order.CalculateTotal() + " kr");
                Console.WriteLine("Betalningsdatum: " + order.Invoice.DueDate);
                
            }
            Console.WriteLine("======================================");
        }
    }
}
