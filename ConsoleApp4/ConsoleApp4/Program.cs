// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
	    List<Product> products  = new List<Product>();
    }
}
class Product
{
    public string Name { get; set; }
    public int Stock { get; set; }

    public double Price { get; set; }
}
