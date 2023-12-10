using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    //Initialize the address
    public Address(string street, string city, string state, string zip)
    {
    _street = street;
    _city = city;
    _state = state;
    _zip = zip;
    }

    //Getters and Setters
    public string Street
    {
        get {return _street;}
        set {_street = value;}
    }

    public string City
    {
        get {return _city;}
        set {_city = value;}
    }

    public string State
    {
        get {return _state;}
        set {_state = value;}
    }

    public string Zip
    {
        get {return _zip;}
        set {_zip = value;}
    }

    //Method to get the full address
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_zip}";
    }
}

