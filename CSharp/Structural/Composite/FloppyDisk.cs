public class FloppyDisk : Equipment
{
    public FloppyDisk(string name, decimal netPriceAlone)
    {
        Name = name;
        NetPriceAlone = netPriceAlone;
    }

    public override decimal NetPrice()
    {
        return NetPriceAlone;
    }
}
