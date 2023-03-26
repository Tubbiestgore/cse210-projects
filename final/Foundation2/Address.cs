using System;
class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool International()
    {
        return _country == "USA";
    }

    public override string ToString()
    {
        return string.Format("Address: {0}\nCity: {1}\nState/Province: {2}\nCountry: {3}", _street, _city, _stateProvince, _country);
    }
}