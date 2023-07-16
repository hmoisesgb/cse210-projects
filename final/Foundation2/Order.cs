public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public double GetTotalPrice(){
        double subtotal = 0;
        double shippingCost = 0;

        foreach (Product p in _products)
        {
            subtotal += p.GetPrice();
        }

        if (_customer.LivesInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return subtotal + shippingCost;
    }

    public void GetProductLabel(){

        Console.WriteLine("Product Label");

        foreach (Product p in _products)
        {
            Console.WriteLine(p.GetProductDetails());
        }
        
        Console.WriteLine();
    }

    public void GetShippingLabel(){
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine(_customer.GetAddress());
        Console.WriteLine();
    }
}