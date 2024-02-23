namespace ShoppingCart.ShoppingDir;

public class Services : iServices
{
    private readonly List<iProduct> products;

    public Services()
    {
        products = new List<iProduct>();
    }

    public void addItem(iProduct prod)
    {
        products.Add(prod);
    }

    public void displayItems()
    {
        foreach (var prod in products)
            Console.WriteLine($"Name = {prod.name} ID = {prod.id} Price = {prod.price} Quantity = {prod.quantity}");
    }

    public void addItems(List<iProduct> prods)
    {
        foreach (var prod in prods)
        {
            var exist = false;

            foreach (var existing in products)
                if (prod.id == existing.id)
                {
                    exist = true;
                    existing.quantity += prod.quantity;
                    break;
                }

            if (!exist) products.Add(prod);
        }
    }

    public void removeItem(iProduct prod)
    {
        products.Remove(prod);
    }

    public int getQuantity()
    {
        var totalQuantity = 0;
        foreach (var product in products) totalQuantity += product.quantity;

        return totalQuantity;
    }

    public int getTotal()
    {
        var totalTotal = 0;

        foreach (var product in products) totalTotal += product.quantity * product.price;

        return totalTotal;
    }


    public iProduct getProductById(int id)
    {
        foreach (var prod in products)
            if (prod.id == id)
                return prod;

        return null;
    }
}