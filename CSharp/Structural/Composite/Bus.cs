// "... a bus can contain cards..." (Gamma et al, 1994)
public class Bus : CompositeEquipment
{
    private string _name;

    public Bus(string name)
    {
        this._name = name;
    }

    public override decimal NetPrice() 
    {
        var children = base.NetPrice();
        return children + 100M;
    }
}