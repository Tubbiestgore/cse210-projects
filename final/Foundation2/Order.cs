using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.Price * product.Quantity;
        }

        if (_customer.Address.International())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "Packing label:\n";
        foreach (Product product in _products)
        {
            label += string.Format("{0} ({1})\n", product.Name, product.Id);
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping label:\n";
        label += string.Format("Name: {0}\n", _customer.Name);
        label += _customer.Address.ToString();

        return label;
    }
}