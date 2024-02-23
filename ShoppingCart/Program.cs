using ShoppingCart;
using ShoppingCart.Membership;
using ShoppingCart.ShoppingDir;
// TestingApp(); //A testing function to ensure all the functionalities work.
Console.WriteLine("Welcome to Shopping Cart:");
Console.WriteLine("Please enter your username, id, and membership level");

string username = Console.ReadLine();
int id = int.Parse(Console.ReadLine());
int level = int.Parse(Console.ReadLine());

Member member = new Member(username, id, level);

Console.WriteLine($"Welcome {member.memberName}, you can continue shopping now");

Services shoppingCart = new Services();

while (true)
{
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
    Console.WriteLine("Enter 1 to add Cloth products to your cart,");
    Console.WriteLine("Enter 2 to add Electronics products to your cart,");
    Console.WriteLine("Enter 3 to add Food products to your cart,");
    Console.WriteLine("Enter 4 to add other products to your cart,");
    Console.WriteLine("5 to see your available discount,");
    Console.WriteLine("6 to checkout,");
    Console.WriteLine("7 to see all the items in your cart,");
    Console.WriteLine("8 to remove an item,");
    Console.WriteLine("9 to see the total quantity in your cart, and");
    Console.WriteLine("10 to exit.");
    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine();
            Console.WriteLine("Enter Cloth name, id, price, quantity and brand");
            string cname = Console.ReadLine();
            int cid = int.Parse(Console.ReadLine());
            int cprice = int.Parse(Console.ReadLine());
            int cquan = int.Parse(Console.ReadLine());
            string cbrand = Console.ReadLine();

            shoppingCart.addItem(new Cloth(cname, cid, cprice, cquan,cbrand));
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine("Enter Electronics Product name, id, price, and quantity");
            string ename = Console.ReadLine();
            int eid = int.Parse(Console.ReadLine());
            int eprice = int.Parse(Console.ReadLine());
            int equan = int.Parse(Console.ReadLine());
            string ebrand = Console.ReadLine();
            
            shoppingCart.addItem(new Electronics(ename, eid, eprice, equan,ebrand));
            Console.WriteLine();
            break;
        case 3:
            
            Console.WriteLine();
            Console.WriteLine("Enter Food name, id, price, and quantity");
            string fname = Console.ReadLine();
            int fid = int.Parse(Console.ReadLine());
            int fprice = int.Parse(Console.ReadLine());
            int fquan = int.Parse(Console.ReadLine());

            shoppingCart.addItem(new Food(fname, fid, fprice, fquan,DateTime.Now,DateTime.Now));
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine();
            Console.WriteLine("Enter Product name, id, price, and quantity");
            string pname = Console.ReadLine();
            int pid = int.Parse(Console.ReadLine());
            int price = int.Parse(Console.ReadLine());
            int quan = int.Parse(Console.ReadLine());

            shoppingCart.addItem(new Product(pname, pid, price, quan));
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine();
            Console.WriteLine(
                $"{member.memberName} is a level {member.membershipLevel} customer, so you will be granted benefits accordingly");
            Console.WriteLine("You are eligible for a discount of: " +
                              member.getDiscount(shoppingCart.getTotal()));
            Console.WriteLine();
            break;

        case 6:
            Console.WriteLine();
            var total = shoppingCart.getTotal();
            Console.WriteLine("Your grand total is: " + member.checkOut(total));
            Console.WriteLine();
            break;

        case 7:
            Console.WriteLine();
            shoppingCart.displayItems();
            Console.WriteLine();
            break;

        case 8:
            Console.WriteLine();
            Console.WriteLine("Enter the id of the product you want to remove:");
            var remId = int.Parse(Console.ReadLine());
            shoppingCart.removeItem(shoppingCart.getProductById(remId));
            Console.WriteLine();
            break;

        case 9:
            Console.WriteLine();
            Console.WriteLine($"The total product quantity is: {shoppingCart.getQuantity()}");
            Console.WriteLine();
            break;

        case 10:
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping with us. Goodbye!");
            Console.WriteLine();
            return;

        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice. Please try again.");
            Console.WriteLine();
            break;
    }   
}

static void TestingApp()
{
    var username = "Jeewan Ghimire";
    var id = 309;
    var level = 2; 

    var member = new Member(username, id, level);
    
    var shoppingCart = new Services();

    shoppingCart.addItem(new Cloth("Shirt", 1, 20, 2, "Brand A"));

    shoppingCart.addItem(new Electronics("Phone", 2, 500, 1, "Brand B"));

    shoppingCart.addItem(new Food("Apple", 3, 2, 5, DateTime.Now, DateTime.Now.AddDays(7)));

    shoppingCart.displayItems();

    var totalQuantity = shoppingCart.getQuantity();
    Console.WriteLine($"Total quantity: {totalQuantity}");

    var totalPrice = shoppingCart.getTotal();
    Console.WriteLine($"Total price: {totalPrice}");

    shoppingCart.removeItem(shoppingCart.getProductById(1));

    shoppingCart.displayItems();

    var checkoutTotal = member.checkOut(totalPrice);
    Console.WriteLine($"Checkout total after discount: {checkoutTotal}");
}