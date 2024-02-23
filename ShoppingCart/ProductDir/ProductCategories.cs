namespace ShoppingCart;

public class Cloth : ProductAbsc
{
    public string brand { get; }

    public Cloth(string name, int id, int price, int quantity, string brand) : base(name, id, price, quantity)
    {
        this.brand = brand;
    }
}

public class Electronics : ProductAbsc
{
    public Electronics(string name, int id, int price, int quantity, string brand) : base(name, id, price, quantity)
    {
        this.brand = brand;
    }

    public string brand { get; }
}

public class Food : ProductAbsc
{
    public Food(string name, int id, int price, int quantity, DateTime manfDate, DateTime expDate) : base(name, id, price, quantity)
    {
        ManfDate = manfDate;
        ExpDate = expDate;
    }

    public DateTime ManfDate { get; }
    public DateTime ExpDate { get; }
    

}