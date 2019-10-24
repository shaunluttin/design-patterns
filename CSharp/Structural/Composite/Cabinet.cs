// "... a cabinet can contain chassis, buses, and so forth..."
// (Gamma et al, 1994)
using System;

public class Cabinet : CompositeEquipment
{
    public Cabinet(string name, decimal netPriceAlone)
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
