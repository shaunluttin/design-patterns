// "... a cabinet can contain chassis, buses, and so forth..." 
// (Gamma et al, 1994)
using System;

public class Cabinet : CompositeEquipment
{
    private string v;

    public Cabinet(string v)
    {
        this.v = v;
    }

    public override decimal NetPrice() 
    {
        var children = base.NetPrice();
        return children + 100M;
    }
}