using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating customers and addresses
        Address usaAddress = new Address("4141 S. Holder Drive", "West Valley", "UT", "84120", "USA");
        Customer usaCustomer = new Customer("Matt Schmitt", usaAddress);

        Address intlAddress = new Address("1010 Clear ST", "Ottawa", "Ontario", "K1A 0B1", "Canada");
        Customer intlCustomer = new Customer("Rick Jones", intlAddress);

        // Products created. Name, ID, price, and quantity
        Product product1 = new Product("Gaming Laptop", 101, 1060.50m, 1);
        Product product2 = new Product("Gaming Mouse", 102, 55.25m, 2);
        Product product3 = new Product("Video Game", 103, 45.99m, 1);

        // Create US and International orders
        Order usaOrder = new Order(usaCustomer);
        usaOrder.AddProduct(product1);
        usaOrder.AddProduct(product2);

        Order intlOrder = new Order(intlCustomer);
        intlOrder.AddProduct(product1);
        intlOrder.AddProduct(product3);

        // Display the results
        usaOrder.Display("US Order");
        intlOrder.Display("International Order");
    }
}