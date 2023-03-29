using System;

class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        name = "";
    }

    public int GetID()
    {
        return _id;
    }

    public void SetID(int id)
    {
        id = 0;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        price = 0;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        quantity = 0;
    }

    public double CalculatePrice()
    {
        return Math.Round((_price * _quantity),2);
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_name}({_id}) => Total: ${CalculatePrice()}");
    }
}