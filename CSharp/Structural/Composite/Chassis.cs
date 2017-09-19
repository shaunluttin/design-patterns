// "a Chassis can contain drives and planar boards..." (Gamma et al, 1994)
public class Chassis : CompositeEquipment
{
    private string v;

    public Chassis(string v)
    {
        this.v = v;
    }
    
    public override decimal NetPrice() 
    {
        var children = base.NetPrice();
        return children + 100M;
    }
}