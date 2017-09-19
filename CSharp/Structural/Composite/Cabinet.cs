// "... a cabinet can contain chassis, buses, and so forth..."
// (Gamma et al, 1994)
using System;

public class Cabinet : CompositeEquipment
{
    private string _name;

    public Cabinet(string name)
    {
        this._name = name;
    }

    public override decimal NetPrice()
    {
        var children = base.NetPrice();
        return children + 100M;
    }
}
