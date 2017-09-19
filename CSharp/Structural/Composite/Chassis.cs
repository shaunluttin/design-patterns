// "a Chassis can contain drives and planar boards..." (Gamma et al, 1994)
public class Chassis : CompositeEquipment
{
    private string _name;

    public Chassis(string name)
    {
        this._name = name;
    }
    
    public override decimal NetPrice() 
    {
        var children = base.NetPrice();
        return children + 100M;
    }
}