using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;

    //Initialize Address properties
    public Address(string street, string city, string state, string zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zip;
        _country = country;
    }

    //Check if address is in USA
    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    //Get the full customer address
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}, {_country}";
    }
}