public class Card : Equipment
{
    private string v;

    public Card(string v)
    {
        this.v = v;
    }

    public override decimal NetPrice()
    {
        throw new System.NotImplementedException();
    }
}