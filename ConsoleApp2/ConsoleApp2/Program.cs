// See https://aka.ms/new-console-template for more information

class Program
{

    static void Main()
    {
        //var phone = new Phone();
        var s21 = new S21();

        Console.WriteLine("Application End");


    }
}

class Phone
{
    public Phone()
    {
        Console.WriteLine("create a new phone");
    }
    public int size;
    public string brand;
    public double price;
}

class S21 : Phone
{
    public S21(double prices)
    {
        Console.WriteLine("create a new  S21");
    }
    public bool NFC;

}
class S22 : S21
{
    public S22(double price2): base(price2)
    {
        Console.WriteLine("create a new  S22");
    } 

    public string dynamicAmoled2;
     

}

