// "... a bus can contain cards..." (Gamma et al, 1994)
public class Bus : CompositeEquipment
{
    public Bus(string name, decimal netPriceAlone)
    {
        Name = name;
        NetPriceAlone = netPriceAlone;
    }

    public override decimal NetPrice()
    {
        var children = base.NetPrice();
        return children + NetPriceAlone;
    }
}
