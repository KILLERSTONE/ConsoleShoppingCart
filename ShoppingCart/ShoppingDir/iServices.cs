namespace ShoppingCart.ShoppingDir;

public interface iServices
{
    void addItem(iProduct prod);
    void removeItem(iProduct prod);
    void addItems(List<iProduct> prods);
    int getQuantity();
    int getTotal();

    void displayItems();
}