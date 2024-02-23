namespace ShoppingCart.Membership;

public class Member : MemberAbsc
{
    public Member(string name, int ph, int level) : base(name, ph, level)
    {
    }


    public int getDiscount(int total)
    {
        switch (membershipLevel)
        {
            case 1:
                return (int)(0.05m * total);
            case 2:
                return (int)(0.1m * total);
            case 3:
                return (int)(0.15m * total);
            default:
                return 0;
        }
    }

    public int checkOut(int total)
    {
        return total - getDiscount(total);
    }

    public string myBenifits()
    {
        switch (membershipLevel)
        {
            case 1:
                return "5% discount on all items";
            case 2:
                return "10% discount on all items";
            case 3:
                return "15% discount on all items + free home delivery";

            default:
                return "Invalid membership";
        }
    }

    public void getMembershipInfo()
    {
        Console.WriteLine("Level 1: No Benifits");
        Console.WriteLine("Level 2: 10% discount on all items");
        Console.WriteLine("Level 3: 15% discount on all items + free home delivery");
    }
}