using System;

class Product
{
    private string _name;
    private int _productID;
    private decimal _price;
    private int _quantity;

    //Initialize Product properties
    public Product(string name, int productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    //Getters and setters
    public decimal Price
    {
        get {return _price;}
        set {_price = value;}
    }

    public int Quantity
    {
        get {return _quantity;}
        set {_quantity = value;}
    }

    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }

    public int ProductID
    {
        get {return _productID;}
        set {_productID = value;}
    }
}