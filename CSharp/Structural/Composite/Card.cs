public class Card : Equipment
{
    public Card(string name, decimal netPriceAlone)
    {
        Name = name;
        NetPriceAlone = netPriceAlone;
    }

    public override decimal NetPrice()
    {
        return NetPriceAlone;
    }
}
