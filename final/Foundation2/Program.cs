using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "San Diego", "CA", "USA");
        Customer customer1 = new Customer("David Keller", address1);

        Address address2 = new Address("456 Stark Strasse", "Karlsruhe", "Baden-Wuertemburg", "Germany");
        Customer customer2 = new Customer("Herr Kramer", address2);

        Product product1 = new Product("Sparkle Beads", 1, 9.99, 2);
        Product product2 = new Product("Nvidia 4065 Graphics Card", 2, 200.99, 1);
        Product product3 = new Product("Cheezewiz", 3, 5.99, 3);
        Product product4 = new Product("Saurkraut", 4, 4.99, 15);
        Product product5 = new Product("Milch", 5, 3.26, 10);
        Product product6 = new Product("Eier", 6, 1.99, 4);

        Order order1 = new Order(customer1, new List<Product>() { product1, product2, product3 });
        Order order2 = new Order(customer2, new List<Product>() { product4, product5, product6 });

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Total Price (including one time shipping cost): ${0}", order1.GetTotalPrice());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Total Price (including one time shipping cost): ${0}", order2.GetTotalPrice());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
    }
}