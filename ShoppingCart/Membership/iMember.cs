namespace ShoppingCart.Membership;

public interface iMember
{
    string memberName { get; }
    int id { get; }

    int membershipLevel { get; set; }
}