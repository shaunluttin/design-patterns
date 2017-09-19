// "Subclasses of Equipment might include Leaf classes that represent
// disc drives, integrated circuits, and switches." (Gamma et al, 1994)
public abstract class Equipment
{
    protected decimal NetPriceAlone { get; set; }

    protected string Name { get; set; }

    public abstract decimal NetPrice();
}
