using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("490 Sandy Boulevard", "San Fransisco", "California", "USA");
        Customer customer1 = new Customer("David Keller", address1);
        double order1ShippingCost = customer1.GetShippingCost();
        Product order1Product1 = new Product("NVIDIA DDX Graphics Card", 15400, 245.99, 1);
        Product order1Product2 = new Product("75 IN FlatScreen TV", 24376, 899.99, 1);
        Product order1Product3 = new Product("Old Fashinoed Root Beer", 435, 1.99, 6);
        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        order1.AddProduct(order1Product3);
        double order1Subtotal = order1.CalculateTotal();
        double order1Total = order1.CalculateFinal();
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCost(order1Subtotal, order1ShippingCost, order1Total);

        Address address2 = new Address("1500 Stark Strasse", "Karlsruhe", "Baden-Wuertemburg", "Deu");
        Customer customer2 = new Customer("Herr Kramer", address2);
        double order2ShippingCost = customer2.GetShippingCost();
        Product order2Product1 = new Product("Milch", 45, 4.75, 1);
        Product order2Product2 = new Product("Eier", 23, 0.20, 12);
        Product order2Product3 = new Product("Brot", 30, 0.85, 2);
        Order order2 = new Order(customer1);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateTotal();
        double order2Total = order2.CalculateFinal();
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCost(order2Subtotal, order2ShippingCost, order2Total);
    }
}