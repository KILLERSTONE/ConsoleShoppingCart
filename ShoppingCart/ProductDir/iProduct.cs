namespace ShoppingCart;

public interface iProduct
{
    string name { get; }
    int id { get; }
    int price { get; }


    int quantity { get; set; }
}