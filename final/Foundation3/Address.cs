using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;

    public Address(string street, string city, string state, int zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        street = "";
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        city = "";
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        state = "";
    }

    public int GetZip()
    {
        return _zip;
    }

    public void SetZip(int zip)
    {
        zip = 0;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        country = "";
    }

    public string GetAddress()
    {
        return $"{_street},\n{_city}, {_state},\n{_zip},{_country}";
    }
}