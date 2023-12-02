using System;

class Customer
{
    private string _name;
    private Address _address;

    //Initialize Customer properties
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Getters and setters
    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }

    public Address CustomerAddress
    {
        get {return _address;}
        set {_address = value;}
    }

    //Check if customer is in USA
    public bool IsUSACustomer()
    {
        return _address.IsUSA();
    }
}