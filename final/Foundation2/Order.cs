using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer {get; set;}

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            double price = product.CalculatePrice();
            total += price;
        }

        total = Math.Round(total, 2);
        return total;
    }

    public double CalculateFinal()
    {
        double total = Math.Round((CalculateTotal() + _customer.GetShippingCost()),2);
        return total;
    }

    public void DisplayCost(double total, double shippingCost, double totalCost)
    {
        Console.WriteLine($"Subtotal: ${total}");
        Console.WriteLine($"Shipping: ${shippingCost}");
        Console.WriteLine($"Total: ${totalCost}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        _customer.DisplayCustomer();
    }





}