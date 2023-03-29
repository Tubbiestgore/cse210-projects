using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        name = "";
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        address = "";
    }

    public double GetShippingCost()
    {
        double shippingCost;
        if(_address.GetCountry() == "USA")
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }
        
        return shippingCost;
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_name}\n{_address.GetAddress()}");
    }
}