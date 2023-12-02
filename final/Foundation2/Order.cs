using System;
using System.Collections.Generic;

class Order
{
    private decimal _shippingCost;
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    //Initialize Customer Properties and set shipping costs
    public Order(Customer customer)
    {
        _customer = customer;

        if (_customer.IsUSACustomer())
        {
            _shippingCost = 5.0m;
        }
        else
        {
            _shippingCost = 35.0m;
        }
    }

    //Adds product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Calculate total cost
    public decimal TotalCost()
    {
        decimal totalPrice = 0;

        foreach (var product in _products)
        {
            decimal productPrice = product.Price * product.Quantity;
            totalPrice += productPrice;
        }

        totalPrice += _shippingCost;

        return totalPrice;
    }

    //Gets packagae label for orders
    public string GetPackageLabel()
    {
        string packageLabel = "";

        foreach (var product in _products)
        {
            packageLabel += $"{product.Name} - Product ID: {product.ProductID} - Quantity: {product.Quantity}\n";
        }

        return packageLabel; 
    }

    //Gets shipping label for orders
    public string GetShippingLabel()
    {
        return $"Customer: {_customer.Name}\nAddress: {_customer.CustomerAddress.GetAddress()}";
    }

    //Display the package label, shipping label, and total price
    public void Display(string orderType)
    {
        Console.WriteLine("---------------------Package Label-----------------------------------");
        Console.WriteLine($"{orderType} Packing Label:\n{GetPackageLabel()}");

        Console.WriteLine("--------------------Shipping Label-----------------------------------");
        Console.WriteLine($"{orderType} Shipping Label:\n{GetShippingLabel()}");
        Console.Write($"Total Price: ${TotalCost()}\n");
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine();
    }
}