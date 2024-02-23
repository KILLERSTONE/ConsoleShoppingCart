namespace ShoppingCart.Membership;

public abstract class MemberAbsc : iMember
{
    public MemberAbsc(string memberName, int memberPh, int membershipLevel)
    {
        this.memberName = memberName;
        id = memberPh;
        this.membershipLevel = membershipLevel;
    }

    public string memberName { get; }
    public int id { get; }
    public int membershipLevel { get; set; }
}