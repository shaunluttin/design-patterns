public class Card : Equipment
{
    private string _name;

    public Card(string name)
    {
        this._name = name;
    }

    public override decimal NetPrice()
    {
        return 100M;
    }
}
