using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating and displaying Order 1
        Address a1 = new Address("3456 Yale St","Houston","Texas","USA");
        Customer c1 = new Customer("Peter Smith", a1);
        Order o1 = new Order(c1);

        Product p1 = new Product("Cookies","3245",2,5);
        o1.AddProduct(p1);
        Product p2 = new Product("Milk", "7632", 10,2);
        o1.AddProduct(p2);
        Product p3 = new Product("Apple", "3215",2,10);
        o1.AddProduct(p3);

        o1.GetProductLabel();
        o1.GetShippingLabel();
        Console.WriteLine($"The total cost of the order is: ${o1.GetTotalPrice()}");
        Console.WriteLine();

        //Creating and displaying Order 2
        Address a2 = new Address("34 Calle 23-56","Guatemala","Guatemala","Guatemala");
        Customer c2 = new Customer("Moises Gonzalez", a2);
        Order o2 = new Order(c2);

        //Products are the same for both orders to show the difference in shipping costs for a non US address
        o2.AddProduct(p1);
        o2.AddProduct(p2);
        o2.AddProduct(p3);

        o2.GetProductLabel();
        o2.GetShippingLabel();
        Console.WriteLine($"The total cost of the order is: ${o2.GetTotalPrice()}");



        
    }
}