// "... a bus can contain cards..." (Gamma et al, 1994)
public class Bus : CompositeEquipment
{
    private string v;

    public Bus(string v)
    {
        this.v = v;
    }

    public override decimal NetPrice() 
    {
        var children = base.NetPrice();
        return children + 100M;
    }
}