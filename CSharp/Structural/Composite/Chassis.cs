// "a Chassis can contain drives and planar boards..." (Gamma et al, 1994)
public class Chassis : CompositeEquipment
{
    public Chassis(string name, decimal netPriceAlone)
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
