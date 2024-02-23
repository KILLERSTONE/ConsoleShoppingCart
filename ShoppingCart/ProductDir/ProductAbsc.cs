namespace ShoppingCart;

public abstract class ProductAbsc : iProduct
{
    public ProductAbsc(string name, int id, int price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string name { get; }
    public int id { get; }
    public int price { get; }

    public int quantity { get; set; }
}